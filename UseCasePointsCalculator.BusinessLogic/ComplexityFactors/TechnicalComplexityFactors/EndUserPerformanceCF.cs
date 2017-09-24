namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class EndUserPerformanceCF : IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Wydajność dla użytkownika końcowego";

        public double Value { get; set; }
    }
}
