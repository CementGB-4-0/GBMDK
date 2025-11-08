using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class BoxGroupAttribute : MetaAttribute, IGroupAttribute
    {
        public BoxGroupAttribute(string name = "")
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}