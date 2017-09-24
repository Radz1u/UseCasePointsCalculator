using System.Linq;

namespace UseCasePointsCalculator.BusinessLogic
{
    public class SimpleUseCasePointCalculator : IUseCasePointsCalculator
    {
        public double CalculateUseCasePoints(Project project)
        {
            double technicalFactorsSum = project.TechnicalFactors.Sum(x => x.Value * x.FactorWeight);

            double enviromentFactorsSum = project.EnviromentFactors.Sum(x => x.Value * x.FactorWeight);

            double tcf = 0.6 + (0.01 * technicalFactorsSum);

            double ecf = 1.4 + (-0.03 * enviromentFactorsSum);

            double uucp = project.UseCases.Sum(x => x.ActorType.Weight + x.UseCaseType.Weight);

            return uucp * ecf * tcf;
        }
    }
}
