namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class EasyToUseCF : IComplexityFactor
    {
        public double FactorWeight => 0.5;

        public string Name => "Łatwość użycia";

        public double Value { get; set; }
    }
}
