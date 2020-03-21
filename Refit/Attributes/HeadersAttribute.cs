using System;

namespace Refit
{
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Method)]
    public class HeadersAttribute : Attribute
    {
        public HeadersAttribute(params string[] headers)
        {
            Headers = headers ?? new string[0];
        }

        public string[] Headers { get; }
    }
}
