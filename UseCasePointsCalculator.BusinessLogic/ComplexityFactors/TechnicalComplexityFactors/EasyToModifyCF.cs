namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class EasyToModifyCF : IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Łatwość wprowadzania zmian";

        public double Value { get; set; }
    }
}
