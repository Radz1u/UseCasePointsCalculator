using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UseCasePointsCalculator.ViewModel
{
    public interface IMainViewModel
    {
        List<ComplexityFactorViewModel> TechnicalFactors { get; set; }

        List<ComplexityFactorViewModel> EnviromentFactors { get; set; }

        ObservableCollection<ActorViewModel> Actors { get; set; }

        ObservableCollection<UseCaseViewModel> UseCases { get; set; }
    }
}
