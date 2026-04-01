using System;

namespace LitJson
{
    public class JsonException : ApplicationException
    {
        internal JsonException(ParserToken token, Exception inner_exception)
        {
        }

        internal JsonException(int c)
        {
        }

        public JsonException(string message)
        {
        }
    }
}