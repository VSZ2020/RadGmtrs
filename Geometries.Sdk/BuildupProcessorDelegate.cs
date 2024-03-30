namespace Geometries.Sdk
{
    /// <summary>
    /// Delegate for buildup processor for uniform medium
    /// </summary>
    /// <param name="mfp">Mean free path</param>
    /// <param name="coefficients"></param>
    /// <returns></returns>
    public delegate double BuildupProcessor(double mfp, in double[] coefficients);

    public delegate double ComplexBuildupProcessor(double[] mfp, in double[][] coefficients, double[]? complexBuildupCoefficients = null);
}
