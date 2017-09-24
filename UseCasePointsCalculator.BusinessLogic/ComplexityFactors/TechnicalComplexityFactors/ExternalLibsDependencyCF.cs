namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class ExternalLibsDependencyCF : IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Zależność od bibliotek zewnętrznych";

        public double Value { get; set; }
    }
}
