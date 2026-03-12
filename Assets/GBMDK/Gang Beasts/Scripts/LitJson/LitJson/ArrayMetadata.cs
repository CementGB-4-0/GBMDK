using System;

namespace LitJson
{
    internal struct ArrayMetadata
    {
        private Type element_type;

        private bool is_array;

        private bool is_list;

        public Type ElementType
        {
            get { return null; }
            set { }
        }

        public bool IsArray
        {
            get { return false; }
            set { }
        }

        public bool IsList
        {
            get { return false; }
            set { }
        }
    }
}