using System.Collections.Generic;

namespace Geometries.Sdk
{
    public interface IGeometryProcessor
    {
        /// <summary>
        /// Information about required dimensions for geometry
        /// </summary>
        /// <returns>Array of dimensions information</returns>
        IEnumerable<DimensionsDetails> GetDimensionsDetails();

        /// <summary>
        /// Returns factor, that converts integral sum to a flux of photons. It's equal one for point source, length for linear source, area for plane source and volume for volumetric source
        /// </summary>
        /// <param name="dimensions"></param>
        /// <returns></returns>
        double GetNormalizationFactor(Dimension[] dimensions);

        /// <summary>
        /// Evaluates flux of photons, expressed in [cm^-2]
        /// </summary>
        /// <param name="inp">Class with a set of calculation parameters</param>
        /// <returns>Photons flux [cm^-2]</returns>
        double ProcessGeometry(ProcessorInput inp);
    }
}
