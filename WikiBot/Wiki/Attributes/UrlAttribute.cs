namespace Wiki
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class UrlAttribute : Attribute
    {
        public UrlAttribute(string url)
        {
            this.Url = url;
        }

        public string Url { get; private set; }
    }
}
