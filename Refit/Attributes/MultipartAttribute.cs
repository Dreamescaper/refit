using System;

namespace Refit
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MultipartAttribute : Attribute
    {
        public string BoundaryText { get; private set; }

        public MultipartAttribute(string boundaryText = "----MyGreatBoundary")
        {
            BoundaryText = boundaryText;
        }
    }
}
