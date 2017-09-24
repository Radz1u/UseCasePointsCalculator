namespace UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors
{
    public class AdditionalUsersTrainingCF : IComplexityFactor
    {
        public double FactorWeight => 1;

        public string Name => "Dodatkowe szkolenia użytkowników";

        public double Value { get; set; }
    }
}
