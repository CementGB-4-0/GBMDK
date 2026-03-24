using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PlayFab.Json
{
    [GeneratedCode("simple-json", "1.0.0")]
    public static class PlayFabSimpleJson
    {
        private const int BUILDER_INIT = 2000;

        private static readonly char[] EscapeTable;

        private static readonly char[] EscapeCharacters;

        internal static readonly List<Type> NumberTypes;

        [ThreadStatic] private static StringBuilder _serializeObjectBuilder;

        [ThreadStatic] private static StringBuilder _parseStringBuilder;

        private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

        private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;

        static PlayFabSimpleJson()
        {
        }

        public static IJsonSerializerStrategy CurrentJsonSerializerStrategy
        {
            get { return null; }
            set { }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static PocoJsonSerializerStrategy PocoJsonSerializerStrategy => null;

        public static object DeserializeObject(string json)
        {
            return null;
        }

        public static bool TryDeserializeObject(string json, out object obj)
        {
            obj = null;
            return false;
        }

        public static object DeserializeObject(string json, Type type,
            IJsonSerializerStrategy jsonSerializerStrategy = null)
        {
            return null;
        }

        public static T DeserializeObject<T>(string json, IJsonSerializerStrategy jsonSerializerStrategy = null)
        {
            return default(T);
        }

        public static string SerializeObject(object json, IJsonSerializerStrategy jsonSerializerStrategy = null)
        {
            return null;
        }

        public static string EscapeToJavascriptString(string jsonString)
        {
            return null;
        }

        private static IDictionary<string, object> ParseObject(string json, ref int index, ref bool success)
        {
            return null;
        }

        private static JsonArray ParseArray(string json, ref int index, ref bool success)
        {
            return null;
        }

        private static object ParseValue(string json, ref int index, ref bool success)
        {
            return null;
        }

        private static string ParseString(string json, ref int index, ref bool success)
        {
            return null;
        }

        private static string ConvertFromUtf32(int utf32)
        {
            return null;
        }

        private static object ParseNumber(string json, ref int index, ref bool success)
        {
            return null;
        }

        private static int GetLastIndexOfNumber(string json, int index)
        {
            return 0;
        }

        private static void EatWhitespace(string json, ref int index)
        {
        }

        private static TokenType LookAhead(string json, int index)
        {
            return default(TokenType);
        }

        private static TokenType NextToken(string json, ref int index)
        {
            return default(TokenType);
        }

        private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value,
            StringBuilder builder)
        {
            return false;
        }

        private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys,
            IEnumerable values, StringBuilder builder)
        {
            return false;
        }

        private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray,
            StringBuilder builder)
        {
            return false;
        }

        private static bool SerializeString(string aString, StringBuilder builder)
        {
            return false;
        }

        private static bool SerializeNumber(object number, StringBuilder builder)
        {
            return false;
        }

        private static bool IsNumeric(object value)
        {
            return false;
        }

        private enum TokenType : byte
        {
            NONE = 0,
            CURLY_OPEN = 1,
            CURLY_CLOSE = 2,
            SQUARED_OPEN = 3,
            SQUARED_CLOSE = 4,
            COLON = 5,
            COMMA = 6,
            STRING = 7,
            NUMBER = 8,
            TRUE = 9,
            FALSE = 10,
            NULL = 11
        }
    }
}