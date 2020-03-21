using System;
using System.Net.Http;

namespace Refit
{
    public abstract class HttpMethodAttribute : Attribute
    {
        public HttpMethodAttribute(string path)
        {
            Path = path;
        }

        public abstract HttpMethod Method { get; }

        public virtual string Path
        {
            get;
            protected set;
        }
    }
}
