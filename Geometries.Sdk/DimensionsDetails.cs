namespace Geometries.Sdk
{
    /// <summary>
    /// Keeps information about dimension
    /// </summary>
    public class DimensionsDetails
    {
        /// <summary>
        /// Name of dimension
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Brief description of dimension
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Measurement units of dimension
        /// </summary>
        public string Units { get; set; }

        /// <summary>
        /// Initial value of the dimension
        /// </summary>
        public float DefaultValue { get; set; }

        /// <summary>
        /// Maximum acceptable dimension value
        /// </summary>
        public float UpperBound { get; set; } = float.MaxValue;

        /// <summary>
        /// Minimum acceptable dimension value
        /// </summary>
        public float LowerBound { get; set; } = 0;

        /// <summary>
        /// Discreteness of the dimension value. Required for Point-Kernel Method
        /// </summary>
        public int Partitioning { get; set; } = 1;
    }
}
