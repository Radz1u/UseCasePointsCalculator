namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class ReUsabilityCF:IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Re-używalność";

        public double Value { get; set; }
    }
}
