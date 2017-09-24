namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.EnviromentComplexityFactors
{
    public class MethodologyKnowlegdeCF : IComplexityFactor
    {
        public double FactorWeight => 1.5;

        public string Name => "Znajomość metodyki";

        public double Value { get; set; }
    }
}
