namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.EnviromentComplexityFactors
{
    public class HalfTimeEmployeesPartCF:IComplexityFactor
    {
        public double FactorWeight => -1;

        public string Name => "Udział pracowników w niepełnym wymiarze godzin";

        public double Value { get; set; }
    }
}
