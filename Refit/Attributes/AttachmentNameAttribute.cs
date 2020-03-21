using System;

namespace Refit
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
    [Obsolete("Use Refit.StreamPart, Refit.ByteArrayPart, Refit.FileInfoPart or if necessary, inherit from Refit.MultipartItem", false)]
    public class AttachmentNameAttribute : Attribute
    {
        public AttachmentNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }
    }
}
