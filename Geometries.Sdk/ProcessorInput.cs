using System.Threading;

namespace Geometries.Sdk
{
    public class ProcessorInput
    {
        /// <summary>
        /// Coordinates of point of flux density or dose registration
        /// </summary>
        public Vector DosePoint = new Vector(0,0,0);

        /// <summary>
        /// Attenuation factors for observed layers of materials. The first factor corresponds to material of the source
        /// </summary>
        public double[]? AttenuationFactors;

        /// <summary>
        /// Array of source shielding layers 
        /// </summary>
        public IShieldLayer[]? Shields;

        /// <summary>
        /// Array of parameters of each source dimension
        /// </summary>
        public Dimension[]? Dimensions;

        /// <summary>
        /// Token applies when evaluation cancellation is required
        /// </summary>
        public CancellationToken Token = CancellationToken.None;

        #region Buildup
        /// <summary>
        /// Sets of coefficients for evaluation of buildup of single material
        /// </summary>
        public double[][]? BuildupCoefficients;

        /// <summary>
        /// Processor of builup factor of single material layer
        /// </summary>
        public BuildupProcessor? BuildupProcessor;

        /// <summary>
        /// Processor of multi-layer buildup factor
        /// </summary>
        public ComplexBuildupProcessor? MultiLayerBuildupProcessor;
        #endregion
    }
}
