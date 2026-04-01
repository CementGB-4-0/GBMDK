namespace LitJson
{
    internal class WriterContext
    {
        public int Count;

        public bool ExpectingValue;

        public bool InArray;

        public bool InObject;

        public int Padding;
    }
}