using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Costumes;
using Femur;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;

[RequireComponent(typeof(Actor))]
public class ActorCostume : NetworkBehaviour
{
	public delegate void CostumeSetHandler();

	[Serializable]
	public class ApplyedCostume
	{
		public CostumeObject CostumeObject;

		public RigCombine.CombinedObject CombinedObject;

		public Mesh[] OriginalMeshes;

		public SkinnedMeshRenderer[] OriginalSKMs;

		public CostumeSaveEntry.CostumeSaveItem CostumeSaveItem;

		public Renderer[] RendererCache;

		public Color[][] MatColors;

		public void CacheMeshes()
		{
		}

		public void CacheMaterialColors()
		{
		}

		public void ResetMeshesToCache()
		{
		}

		public void ResetMaterialColors()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSetCostume_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActorCostume _003C_003E4__this;

		public CostumeSaveEntry costumeSaveEntry;

		public RigCombine rigCombine;

		public RemoveUnseenMesh removeUnseenMesh;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSetCostume_003Ed__39(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CApplyCostumePreset_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActorCostume _003C_003E4__this;

		public string costumePresetName;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CApplyCostumePreset_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CUpdateCostume_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActorCostume _003C_003E4__this;

		public CostumeSaveEntry costumeSaveEntry;

		public RigCombine rigCombine;

		public RemoveUnseenMesh removeUnseenMesh;

		private List<CostumeObject> _003CnewCostumeObjects_003E5__2;

		private List<CostumeSaveEntry.CostumeSaveItem> _003CnewCostumeSaveItems_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateCostume_003Ed__49(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadCostumeItems_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActorCostume _003C_003E4__this;

		public List<CostumeObject> newCostumeObjects;

		private AsyncOperationHandle<IList<GameObject>>[] _003Cops_003E5__2;

		private bool _003ChasPendingOperations_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadCostumeItems_003Ed__52(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CFinalizeSetCostume_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActorCostume _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFinalizeSetCostume_003Ed__55(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDeferFinalizeSetCostume_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActorCostume _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDeferFinalizeSetCostume_003Ed__56(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public const int TintCount = 4;

	public bool SetVoice;

	public bool RunRemoveUnseenMesh;

	public bool SendOnCostumeSetEvent;

	public bool CacheMeshesBeforeReduce;

	[SerializeField]
	private CostumeSaveEntryStruct SaveEntryStruct;

	[SerializeField]
	private List<ApplyedCostume> ApplyedCostumes;

	[HideInInspector]
	[SerializeField]
	private string _costumePresetName;

	[SerializeField]
	private SkinnedMeshRenderer Body;

	[SerializeField]
	private SkinnedMeshRenderer Head;

	[SerializeField]
	private Mesh _bodyMeshBackup;

	[SerializeField]
	private Mesh _headMeshBackup;

	private Actor _actor;

	private GameObject[][] _costumeItemsCache;

	private bool _shouldDraw;

	private List<SkinnedMeshRenderer> _skinnedMeshRenderers;

	private List<MeshRenderer> _meshRenderers;

	private Coroutine _coroutineSetCostume;

	public CostumeDatabase CostumeDatabase { get; private set; }

	public CostumePresetDatabase CostumePresetDatabase { get; private set; }

	public CostumeSaveEntry SaveEntry
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string CostumePresetName => null;

	public bool ShouldDraw
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event CostumeSetHandler OnCostumeSet
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CSetCostume_003Ed__39))]
	public IEnumerator SetCostume(CostumeSaveEntry costumeSaveEntry, RigCombine rigCombine = null, RemoveUnseenMesh removeUnseenMesh = null)
	{
		return null;
	}

	public void SetCostumeSeq(CostumeSaveEntry costumeSaveEntry, RigCombine rigCombine = null, RemoveUnseenMesh removeUnseenMesh = null)
	{
	}

	[IteratorStateMachine(typeof(_003CApplyCostumePreset_003Ed__41))]
	public IEnumerator ApplyCostumePreset(string costumePresetName)
	{
		return null;
	}

	public int GetTintRange(ushort uid)
	{
		return 0;
	}

	public void UpdateCostumeTint(Color value)
	{
	}

	public void SetCostumeTint(Color value)
	{
	}

	public bool IsTintable(ushort uid)
	{
		return false;
	}

	public List<GameObject> GetMeshesForPart(CostumeParts part)
	{
		return null;
	}

	public void ForceShouldDraw()
	{
	}

	private void ApplyShouldDraw()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateCostume_003Ed__49))]
	private IEnumerator UpdateCostume(CostumeSaveEntry costumeSaveEntry, RigCombine rigCombine = null, RemoveUnseenMesh removeUnseenMesh = null)
	{
		return null;
	}

	private void UpdateVoice(CostumeSaveEntry costumeSaveEntry)
	{
	}

	private void IdentifyNewCostumeObjects(CostumeSaveEntry costumeSaveEntry, ref List<CostumeObject> newCostumeObjects, ref List<CostumeSaveEntry.CostumeSaveItem> newCostumeSaveItems)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadCostumeItems_003Ed__52))]
	private IEnumerator LoadCostumeItems(List<CostumeObject> newCostumeObjects)
	{
		return null;
	}

	private void ApplyNewCostumeObjects(List<CostumeObject> newCostumeObjects, List<CostumeSaveEntry.CostumeSaveItem> newCostumeSaveItems, RigCombine rigCombine)
	{
	}

	private void RemoveUnseenMesh(RemoveUnseenMesh removeUnseenMesh)
	{
	}

	[IteratorStateMachine(typeof(_003CFinalizeSetCostume_003Ed__55))]
	private IEnumerator FinalizeSetCostume()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDeferFinalizeSetCostume_003Ed__56))]
	private IEnumerator DeferFinalizeSetCostume()
	{
		return null;
	}

	private void OnFinalizedSetCostume()
	{
	}

	public void ResetCostume()
	{
	}

	private void ResetCostumePart(RigCombine.CombinedObject combinedObject)
	{
	}

	private bool SharesAddedObject(RigCombine.CombinedObject combinedObject, GameObject go)
	{
		return false;
	}

	private void ResetCostumeMeshies()
	{
	}

	private Color GetHairTint(Color value, int level)
	{
		return default(Color);
	}

	private Color GetPlayerTint(Color value, int level)
	{
		return default(Color);
	}

	private void ClearRendererCache()
	{
	}

	private void UNetVersion()
	{
	}

	public override bool OnSerialize(NetworkWriter writer, bool forceAll)
	{
		return false;
	}

	public override void OnDeserialize(NetworkReader reader, bool initialState)
	{
	}

	public override void PreStartClient()
	{
	}
}
