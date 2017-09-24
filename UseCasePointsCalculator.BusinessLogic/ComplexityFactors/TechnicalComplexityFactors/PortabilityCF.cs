namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class PortabilityCF : IComplexityFactor
    {
        public double FactorWeight => 2;

        public string Name => "Przenośność";

        public double Value { get; set; }
    }
}
