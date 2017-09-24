using System.Collections.Generic;

namespace UseCasePointsCalculator.BusinessLogic
{
    public class UseCase
    {
        public IActorType ActorType { get; }

        public IUseCaseType UseCaseType { get; }

        public UseCase(IActorType actorType, IUseCaseType useCaseType)
        {
            this.ActorType = actorType;
            this.UseCaseType = useCaseType;
        }
    }
}
