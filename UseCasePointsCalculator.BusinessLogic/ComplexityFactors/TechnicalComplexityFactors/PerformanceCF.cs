namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class PerformanceCF :IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Wydajność";

        public double Value { get; set; }
    }
}
