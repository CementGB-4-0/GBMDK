using System;

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class RequiredAttribute : ValidatorAttribute
    {
        public RequiredAttribute(string message = null)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}