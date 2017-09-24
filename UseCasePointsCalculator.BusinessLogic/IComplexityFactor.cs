namespace UseCasePointsCalculator.BusinessLogic
{
    public interface IComplexityFactor
    {
        string Name { get; }

        double FactorWeight { get; }

        double Value { get; set; }
    }
}
