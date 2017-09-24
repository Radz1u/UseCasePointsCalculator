namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.EnviromentComplexityFactors
{
    public class ObjectOrientedTechniqueKnowledgeCF : IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Znajomość technik obiektowych";

        public double Value { get; set; }
    }
}
