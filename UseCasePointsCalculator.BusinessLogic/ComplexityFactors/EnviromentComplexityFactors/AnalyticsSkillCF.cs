namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.EnviromentComplexityFactors
{
    public class AnalyticsSkillCF : IComplexityFactor
    {
        public double FactorWeight => 0.5;

        public string Name => "Umiejętności analityka";

        public double Value { get; set; }
    }
}
