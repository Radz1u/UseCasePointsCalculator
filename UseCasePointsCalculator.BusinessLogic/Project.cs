using System.Collections.Generic;

namespace UseCasePointsCalculator.BusinessLogic
{
    public class Project
    {
        public IEnumerable<IComplexityFactor> TechnicalFactors { get; }

        public IEnumerable<IComplexityFactor> EnviromentFactors { get; }

        public IEnumerable<UseCase> UseCases { get; }

        public Project(IEnumerable<IComplexityFactor> technicalFactors, IEnumerable<IComplexityFactor> enviromentFactors, IEnumerable<UseCase> useCases)
        {
            TechnicalFactors = technicalFactors;
            EnviromentFactors = enviromentFactors;
            UseCases = useCases;
        }
    }
}
