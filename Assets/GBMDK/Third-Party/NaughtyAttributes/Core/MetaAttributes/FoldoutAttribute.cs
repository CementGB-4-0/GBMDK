using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class FoldoutAttribute : MetaAttribute, IGroupAttribute
    {
        public FoldoutAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}