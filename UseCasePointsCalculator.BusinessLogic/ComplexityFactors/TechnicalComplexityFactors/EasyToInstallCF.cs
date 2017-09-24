namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class EasyToInstallCF : IComplexityFactor
    {
        public double FactorWeight => 0.5;

        public string Name => "Łatwość instalacji";

        public double Value { get; set; }
    }
}
