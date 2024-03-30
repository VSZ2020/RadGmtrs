namespace Geometries.Sdk
{
    /// <summary>
    /// Common interface for all forms of shield layer
    /// </summary>
    public interface IShieldLayer
    {
        public double GetThickness(TargetPoint? target = null);
    }
}
