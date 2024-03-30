using Geometries.Sdk.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Geometries.Sdk.Examples
{
    [GeometryProcessor]
    public class PointProcessor : IGeometryProcessor
    {
        public IEnumerable<DimensionsDetails> GetDimensionsDetails()
        {
            //Point sourse hasn't any dimension, so empty list is returned
            return Enumerable.Empty<DimensionsDetails>();
        }

        public double GetNormalizationFactor(Dimension[] dimensions)
        {
            return 1;
        }

        public double ProcessGeometry(ProcessorInput inp)
        {
            var X = inp.DosePoint.X;
            var Y = inp.DosePoint.Y;
            var Z = inp.DosePoint.Z;

            double RSquare =  X * X + Y * Y + Z * Z;

            var shieldThicknesses = inp.Shields.Select(s => s.GetThickness()).ToArray();

            //MFP is Mean Free Path, that is expressed in [cm]
            var mfps = Enumerable.Range(0, shieldThicknesses.Length).Select(i => inp.AttenuationFactors[i] * shieldThicknesses[i]).ToArray();

            //Exponential factor taking into account radiation attenuation 
            var looseExp = Math.Exp(-mfps.Sum());

            //Buildup factor for multi-layer layers
            var buildup = inp.MultiLayerBuildupProcessor != null ? inp.MultiLayerBuildupProcessor(mfps, inp.BuildupCoefficients) : 1.0;

            //Normalization factor could be ignored, because it's one
            return looseExp * buildup / (4.0 * Math.PI * RSquare) / GetNormalizationFactor(null!);
        }
    }
}
