namespace Wiki
{
    using System;

    using Data.Enums;

    [AttributeUsage(AttributeTargets.Field)]
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(DataType dataType)
        {
            this.DataType = dataType;
        }

        public DataType DataType { get; private set; }
    }
}
