using GalaSoft.MvvmLight;
using UseCasePointsCalculator.BusinessLogic;

namespace UseCasePointsCalculator.ViewModel
{
    public class ActorViewModel : ViewModelBase
    {
        public string Name { get; }

        public IActorType Type { get; }
        
        public ActorViewModel(string name, IActorType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
