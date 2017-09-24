using GalaSoft.MvvmLight;
using UseCasePointsCalculator.BusinessLogic;

namespace UseCasePointsCalculator.ViewModel
{
    public class UseCaseViewModel : ViewModelBase
    {
        public string Name { get; }

        public ActorViewModel Actor { get; }

        public IUseCaseType Type { get; }

        public UseCaseViewModel(ActorViewModel actor, IUseCaseType type, string name)
        {
            Name = name;
            Type = type;
            Actor = actor;
        }

        public override string ToString()
        {
            return $"{Name}, {Actor.Name}";
        }
    }
}
