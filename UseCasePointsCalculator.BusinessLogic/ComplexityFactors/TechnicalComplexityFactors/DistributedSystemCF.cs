namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class DistributedSystemCF  :IComplexityFactor
    {
        public double FactorWeight => 2;

        public string Name => "System rozproszony";

        public double Value { get; set; }
    }
}
