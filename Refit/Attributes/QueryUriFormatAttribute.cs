using System;

namespace Refit
{
    [AttributeUsage(AttributeTargets.Method)]
    public class QueryUriFormatAttribute : Attribute
    {
        public QueryUriFormatAttribute(UriFormat uriFormat)
        {
            UriFormat = uriFormat;
        }

        /// <summary>
        /// Specifies how the Query Params should be encoded.
        /// </summary>
        public UriFormat UriFormat { get; }
    }
}
