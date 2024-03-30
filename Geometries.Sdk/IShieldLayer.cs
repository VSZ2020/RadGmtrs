namespace Geometries.Sdk
{
    /// <summary>
    /// Common interface for all forms of shield layer
    /// </summary>
    public interface IShieldLayer
    {
        /// <summary>
        /// Evaluates effective shield thickness
        /// </summary>
        /// <param name="source">Coordinates of point source location</param>
        /// <param name="target">Coordinates of dose point</param>
        /// <returns></returns>
        public double GetThickness(Vector? source = null, Vector? target = null);
    }
}
