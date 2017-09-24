namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.EnviromentComplexityFactors
{
    public class RequirementsStabilityCF : IComplexityFactor
    {
        public double FactorWeight => 2;

        public string Name => "Stabilność wymagań";

        public double Value { get; set; }
    }
}
