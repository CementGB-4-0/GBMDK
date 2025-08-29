using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Coatsink.Common
{
	public static class Serializer
	{
		private class ColorConstructor : IExternalConstructor
		{
			public void Deconstruct(object obj, Type type, BinaryWriter writer)
			{
			}

			public object Reconstruct(Type type, BinaryReader reader)
			{
				return null;
			}
		}

		private class Vector3Constructor : IExternalConstructor
		{
			public void Deconstruct(object obj, Type type, BinaryWriter writer)
			{
			}

			public object Reconstruct(Type type, BinaryReader reader)
			{
				return null;
			}
		}

		private class Vector2Constructor : IExternalConstructor
		{
			public void Deconstruct(object obj, Type type, BinaryWriter writer)
			{
			}

			public object Reconstruct(Type type, BinaryReader reader)
			{
				return null;
			}
		}

		private class NameSorter : IComparer<KeyValuePair<string, int>>
		{
			public int Compare(KeyValuePair<string, int> x, KeyValuePair<string, int> y)
			{
				return 0;
			}
		}

		[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
		public class ExcludeAllFields : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
		public class ExcludeAllFieldsFromAssignablesTo : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
		public class ExcludeAssignablesTo : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field)]
		public class Exclude : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Class)]
		public class ExcludeEnabled : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
		public abstract class ExternalConstructor : Attribute, IExternalConstructor
		{
			public abstract void Deconstruct(object obj, Type type, BinaryWriter writer);

			public abstract object Reconstruct(Type type, BinaryReader reader);
		}

		[AttributeUsage(AttributeTargets.Class)]
		public abstract class ExternalResourceAcquisitor : Attribute
		{
			public abstract void Deacquire(ScriptableResource obj, Type type, BinaryWriter writer);

			public abstract ScriptableResource Reacquire(string path, Type type, BinaryReader reader);
		}

		[AttributeUsage(AttributeTargets.Class)]
		public abstract class ExternalPrefabReacquisitor : Attribute
		{
			public abstract void Deacquire(Serializer_Prefab instance, BinaryWriter writer);

			public abstract GameObject Reacquire(string path, BinaryReader reader);
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class StaticMemberLimit : Attribute
		{
			public int limit;

			public StaticMemberLimit(int limit)
			{
			}
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class DynamicMemberLimit : Attribute
		{
		}

		public interface ISelfConstructor
		{
			void Deconstruct(BinaryWriter writer);
		}

		public interface IExternalConstructor
		{
			void Deconstruct(object obj, Type type, BinaryWriter writer);

			object Reconstruct(Type type, BinaryReader reader);
		}

		public interface IMemberSink
		{
			string this[string name] { set; }
		}

		public interface IMemberSource
		{
			object this[string name] { get; }

			bool TryGet<T>(string name, ref T val);

			T Get<T>(string name);
		}

		public interface ISelfComposer
		{
			void Decompose(IMemberSink members);

			void Recompose(IMemberSource members);
		}

		public interface IMemberLimiter
		{
			int GetMemberLimit(string fieldName);
		}

		private struct DeconstructedObject
		{
			public object obj;

			public Type type;

			public byte hint;

			public int memIdx;

			public int memQty;

			public int size;
		}

		private static class Hint
		{
			public const byte None = 0;

			public const byte String = 1;

			public const byte Enum = 2;

			public const byte Resource = 3;

			public const byte Type = 4;

			public const byte FieldInfo = 5;

			public const byte Buffer = 6;

			public const byte GameObject = 7;

			public const byte Component = 8;

			public const byte List = 9;

			public const byte Dictionary = 10;
		}

		private struct DeconstructedPrefab
		{
			public byte order;

			public Serializer_Prefab instance;
		}

		private struct DeconstructedMember
		{
			[StructLayout((LayoutKind)2)]
			public struct Value
			{
				[FieldOffset(0)]
				public byte typeCode;

				[FieldOffset(0)]
				public bool custom;

				[FieldOffset(1)]
				public int index;

				[FieldOffset(1)]
				public primitive prim;
			}

			public string name;

			public Value key;

			public Value val;
		}

		private class CustomMemberBuffer : IMemberSink, IMemberSource
		{
			public Dictionary<string, object> members;

			public object this[string name]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool TryGet<T>(string name, ref T val)
			{
				return false;
			}

			public T Get<T>(string name)
			{
				return default(T);
			}

            string IMemberSink.this[string name]
            {
                set => throw new NotImplementedException();
            }
        }

		private static int retentions;

		private const int initialObjectCapacity = 65536;

		private const int initialMemberCapacity = 524288;

		private const int initialParsedPrefabCapacity = 128;

		private const int initialBufferBufferSize = 2048;

		private const int nullValue = -1;

		private const int excluded = -2;

		private static DeconstructedObject[] deconObjs;

		private static int objQty;

		private static int memQty;

		private static int prefabQty;

		private static Dictionary<object, int> deconObjIdxs;

		private static DeconstructedPrefab[] deconPrefabs;

		private static DeconstructedMember[] deconMems;

		private static CustomMemberBuffer customMemberBuffer;

		private static object[] constrParams;

		private static byte[] bufferBuffer;

		private static Dictionary<Type, FieldInfo[]> fieldCache;

		private static List<FieldInfo> fieldBuffer;

		private static Dictionary<Type, IExternalConstructor> extraExternalConstructor;

		private static List<Type> extraExcludeAllFields;

		private static List<Type> extraExcludeAllFieldsFromAssignablesTo;

		private static List<Type> extraExclude;

		private static List<Type> extraExcludeAssignablesTo;

		private static List<Serializer_Prefab> prefabCompBuffer;

		private const bool logByDefault = false;

		private static TextWriter debugLog;

		private static Stack<string> logStack;

		private static string logFolderPath;

		private static int mainThreadID;

		private static Dictionary<Type, int> instanceCounts;

		public static bool initialised => false;

		public static void Retain(bool silent = false)
		{
		}

		public static void Release(bool silent = false)
		{
		}

		public static void SerializeToStream(object obj, Stream output, bool log = false, string overrideLogPath = null)
		{
		}

		public static void SerializeToFile(object obj, string path, bool log = false, string overrideLogPath = null)
		{
		}

		public static byte[] SerializeToMemory(object obj, int capacity = -1, bool log = false, string overrideLogPath = null)
		{
			return null;
		}

		public static int SerializeToMemory(object obj, byte[] memory, bool clearRemainder = true, int startIndex = 0, int count = -1, bool log = false, string overrideLogPath = null)
		{
			return 0;
		}

		public static T DeserialiseFromStream<T>(Stream input, bool log = false, string overrideLogPath = null) where T : class
		{
			return null;
		}

		public static T DeserialiseFromFile<T>(string path, bool log = false, string overrideLogPath = null) where T : class
		{
			return null;
		}

		public static T DeserialiseFromMemory<T>(byte[] memory, int startIndex = 0, int byteCount = -1, bool log = false, string overrideLogPath = null) where T : class
		{
			return null;
		}

		public static void AddExternalConstructor<T>(IExternalConstructor constructor)
		{
		}

		public static void RemoveExternalConstructor<T>(IExternalConstructor constructor)
		{
		}

		public static void AddExcludeAllFields<T>()
		{
		}

		public static void RemoveExcludeAllFields<T>()
		{
		}

		public static void AddExclude<T>()
		{
		}

		public static void RemoveExclude<T>()
		{
		}

		public static void AddExcludeAssignablesTo<T>()
		{
		}

		public static void RemoveExcludeAssignablesTo<T>()
		{
		}

		public static FieldInfo[] GetIncludedFields(this Type type)
		{
			return null;
		}

		private static void ValidateObjectCap(int reqIdx)
		{
		}

		private static void ValidateMemberCap(int reqIdx)
		{
		}

		private static void ValidatePrefabCap(int reqIdx)
		{
		}

		private static int Deconstruct(object obj, int referrerIdx, int memLimit = int.MaxValue)
		{
			return 0;
		}

		public static bool ExcludedBySerializer(this Type type)
		{
			return false;
		}

		private static void QueryFields(int objIdx, out FieldInfo[] fields)
		{
			fields = null;
		}

		private static void DeconstructFields(int objIdx, int startmi, FieldInfo[] fields)
		{
		}

		private static void DeconstructMemberValue(object val, int objIdx, ref DeconstructedMember.Value deconVal, int memLimit = int.MaxValue)
		{
		}

		private static void TryDeconstructPrefab(GameObject go, Component comp, ref int runningPrefabIdx)
		{
		}

		private static void StartLogging(Type type, bool serialising, string path)
		{
		}

		private static void LogDeconstructionStart()
		{
		}

		private static void LogObjectDeconstruct(int idx, int ownerIdx, int limit, int prefabQty)
		{
		}

		private static void LogPrimParse(string fieldName, DeconstructedMember.Value valRec)
		{
		}

		private static void LogPrimParse(DeconstructedMember.Value valRec)
		{
		}

		private static void LogPushMember(string name)
		{
		}

		private static void LogPushMemberParse(int idx)
		{
		}

		private static void LogPushMemberParse(bool key)
		{
		}

		private static void LogPopMember()
		{
		}

		private static void LogPrefabReadWriteStart()
		{
		}

		private static void LogPrefabReadWrite(long pos, string prefabPath, string parentPath, string name, Vector3 position, Exception exc = null)
		{
		}

		private static void LogObjectReadWriteStart()
		{
		}

		private static void LogObjectReadWrite(long pos, int idx, Type type)
		{
		}

		private static void LogListMemberReadWrite(long pos, int mi, DeconstructedMember.Value valRec)
		{
		}

		private static void LogDictMemberReadWrite(long pos, DeconstructedMember.Value keyRec, DeconstructedMember.Value valRec)
		{
		}

		private static void LogRegularMemberReadWrite(long pos, string name, DeconstructedMember.Value valRec)
		{
		}

		private static void LogMemberReadWrite(DeconstructedMember.Value valRec)
		{
		}

		private static void LogFailedReacquisition(Type type, string path, int idx)
		{
		}

		private static void LogFailedReconstruction(Type type, int idx)
		{
		}

		private static void LogException(Exception exc, int idx)
		{
		}

		private static void EndLogging(string overrideLogPath)
		{
		}

		[Conditional("CS_DEBUG")]
		[Conditional("ENABLE_PROFILER")]
		private static void PushProfile(string title)
		{
		}

		[Conditional("CS_DEBUG")]
		[Conditional("ENABLE_PROFILER")]
		private static void PopProfile()
		{
		}

		private static void ReadPrefab(BinaryReader reader)
		{
		}

		private static void ReadObject(BinaryReader reader, ref DeconstructedObject record, int objIdx)
		{
		}

		private static void ReadMemberValue(BinaryReader reader, ref DeconstructedMember.Value val)
		{
		}

		private static void ReconstructMembers(BinaryReader reader, ref DeconstructedObject record)
		{
		}

		private static void SelfRecompose(BinaryReader reader, int idx, ref DeconstructedObject record)
		{
		}

		private static bool ReconstructMemberValue(DeconstructedMember.Value decon, out object val)
		{
			val = null;
			return false;
		}

		private static bool WritePrefabs(BinaryWriter writer, byte order, int prefabQty)
		{
			return false;
		}

		private static void WriteObject(BinaryWriter writer, int idx)
		{
		}

		private static void WriteMemberValue(BinaryWriter writer, DeconstructedMember.Value val)
		{
		}
	}
}
