namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class SpecialProtectionCF : IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Specjalne zabezpieczenia";

        public double Value { get; set; }
    }
}
