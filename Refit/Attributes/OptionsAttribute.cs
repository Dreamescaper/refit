using System;
using System.Net.Http;

namespace Refit
{
    [AttributeUsage(AttributeTargets.Method)]
    public class OptionsAttribute : HttpMethodAttribute
    {
        public OptionsAttribute(string path) : base(path) { }

        public override HttpMethod Method
        {
            get { return new HttpMethod("OPTIONS"); }
        }
    }
}
