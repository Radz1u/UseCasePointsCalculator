namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.EnviromentComplexityFactors
{
    public class TeamMotivationCF : IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Motywacja zespołu";

        public double Value { get; set; }
    }
}
