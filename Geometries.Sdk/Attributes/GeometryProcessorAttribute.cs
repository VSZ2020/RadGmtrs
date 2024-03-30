using System;

namespace Geometries.Sdk.Attributes
{
    /// <summary>
    /// Mark your geometry processor with this attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class GeometryProcessorAttribute: Attribute
    {
        public string Name { get; }
        public string Description { get; }
        public string Author { get; }
    }
}
