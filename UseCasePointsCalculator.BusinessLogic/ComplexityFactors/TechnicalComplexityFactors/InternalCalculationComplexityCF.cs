namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class InternalCalculationComplexityCF : IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Złożone przetwarzanie wewnętrzne";

        public double Value { get; set; }
    }
}
