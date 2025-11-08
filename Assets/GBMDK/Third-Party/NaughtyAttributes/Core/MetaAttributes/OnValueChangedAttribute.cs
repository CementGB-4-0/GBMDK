using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class OnValueChangedAttribute : MetaAttribute
    {
        public OnValueChangedAttribute(string callbackName)
        {
            CallbackName = callbackName;
        }

        public string CallbackName { get; private set; }
    }
}