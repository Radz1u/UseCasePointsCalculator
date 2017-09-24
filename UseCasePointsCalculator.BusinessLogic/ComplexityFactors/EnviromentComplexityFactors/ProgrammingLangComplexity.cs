namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.EnviromentComplexityFactors
{
    public class ProgrammingLangComplexity: IComplexityFactor
    {
        public double FactorWeight => -1;

        public string Name => "Skomplikowany język programowania";

        public double Value { get; set; }
    }
}
