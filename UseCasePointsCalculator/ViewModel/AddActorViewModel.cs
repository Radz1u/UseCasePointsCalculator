using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePointsCalculator.BusinessLogic;
using UseCasePointsCalculator.BusinessLogic.ActorTypes;

namespace UseCasePointsCalculator.ViewModel
{
    public class AddActorViewModel : ViewModelBase
    {
        private IMainViewModel mainViewModelHandler;
        private string actorName;
        private IActorType selectedActorType;

        public string ActorName
        {
            get { return actorName; }
            set
            {
                actorName = value;
                RaisePropertyChanged();
            }
        }

        public IActorType SelectedActorType
        {
            get
            {
                return selectedActorType;
            }

            set
            {
                selectedActorType = value;
                RaisePropertyChanged();
            }
        }

        public List<IActorType> ActorTypes => new List<IActorType> { new EasyActorType(), new MediumActorType(), new HardActorType() };

        public AddActorViewModel( IMainViewModel mainViewModelHandler)
        {
            this.mainViewModelHandler = mainViewModelHandler;
        }

        public void AddActor()
        {
            this.mainViewModelHandler.Actors.Add(new ActorViewModel(actorName, selectedActorType));
        }
    }
}
