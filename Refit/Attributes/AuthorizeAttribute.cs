using System;

namespace Refit
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class AuthorizeAttribute : HeaderAttribute
    {
        public AuthorizeAttribute(string scheme = "Bearer")
            : base("Authorization: " + scheme) { }
    }
}
