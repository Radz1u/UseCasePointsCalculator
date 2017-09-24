namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.EnviromentComplexityFactors
{
    public class ExpirienceCF : IComplexityFactor
    {
        public double FactorWeight => 0.5;

        public string Name => "Doświadczenie";

        public double Value { get; set; }
    }
}
