namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class ConcurrencyCF : IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Współbieżność";

        public double Value { get; set; }
    }
}
