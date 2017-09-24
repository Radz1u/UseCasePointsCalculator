using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UseCasePointsCalculator.BusinessLogic;
using UseCasePointsCalculator.BusinessLogic.UseCaseTypes;

namespace UseCasePointsCalculator.ViewModel
{
    public class AddUseCaseViewModel : ViewModelBase
    {
        private IMainViewModel mainViewModelHandler;

        private string name;

        private ActorViewModel selectedActor;

        private IUseCaseType selectedUseCaseType;

        public List<IUseCaseType> UseCaseTypes => new List<IUseCaseType> { new EasyUseCaseType(), new MediumUseCaseType(), new HardUseCaseType() };

        public ObservableCollection<ActorViewModel> Actors => mainViewModelHandler?.Actors;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }

        public ActorViewModel SelectedActor
        {
            get { return selectedActor; }
            set
            {
                selectedActor = value;
                RaisePropertyChanged();
            }
        }

        public IUseCaseType SelectedUseCaseType
        {
            get { return selectedUseCaseType; }
            set
            {
                selectedUseCaseType = value;
                RaisePropertyChanged();
            }
        }

        public AddUseCaseViewModel(IMainViewModel mainViewModelHandler)
        {
            this.mainViewModelHandler = mainViewModelHandler;
        }

        public void AddUseCase()
        {
            if (Actors == null || !Actors.Any())
            {
                return;
            }

            this.mainViewModelHandler.UseCases.Add(new UseCaseViewModel(selectedActor, selectedUseCaseType, name));
        }
    }
}
