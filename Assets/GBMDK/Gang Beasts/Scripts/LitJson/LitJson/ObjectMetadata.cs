using System;
using System.Collections.Generic;

namespace LitJson
{
    internal struct ObjectMetadata
    {
        private Type element_type;

        private bool is_dictionary;

        private IDictionary<string, PropertyMetadata> properties;

        public Type ElementType
        {
            get { return null; }
            set { }
        }

        public bool IsDictionary
        {
            get { return false; }
            set { }
        }

        public IDictionary<string, PropertyMetadata> Properties
        {
            get { return null; }
            set { }
        }
    }
}