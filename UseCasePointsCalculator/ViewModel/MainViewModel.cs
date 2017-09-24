using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UseCasePointsCalculator.BusinessLogic;
using UseCasePointsCalculator.BusinessLogic.ComplexityFactors.EnviromentComplexityFactors;
using UseCasePointsCalculator.BusinessLogic.ComplexityFactors.TechnicalComplexityFactors;

namespace UseCasePointsCalculator.ViewModel
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private double useCasePoints;

        private AddActorViewModel addActorVM;

        private AddUseCaseViewModel addUseCaseVM;

        public List<ComplexityFactorViewModel> TechnicalFactors { get; set; }

        public List<ComplexityFactorViewModel> EnviromentFactors { get; set; }

        public ObservableCollection<ActorViewModel> Actors { get; set; }

        public ObservableCollection<UseCaseViewModel> UseCases { get; set; }

        public AddActorViewModel AddActorVM
        {
            get { return addActorVM; }
            set
            {
                addActorVM = value;
                RaisePropertyChanged();
            }
        }

        public AddUseCaseViewModel AddUseCaseVM
        {
            get { return addUseCaseVM; }
            set
            {
                addUseCaseVM = value;
                RaisePropertyChanged();
            }
        }

        public double UseCasePoints
        {
            get
            {
                return useCasePoints;
            }

            set
            {
                useCasePoints = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            Actors = new ObservableCollection<ActorViewModel>();
            UseCases = new ObservableCollection<UseCaseViewModel>();
            CreateEnviromentFactors();
            CreateTechnicalFactors();
        }

        public void Calculate()
        {
            var uc = UseCases.Select(x => new UseCase(x.Actor.Type, x.Type));
            var tcf = TechnicalFactors.Select(x => x.ComplexityFactor);
            var ecf = EnviromentFactors.Select(x => x.ComplexityFactor);

            var project = new Project(tcf, ecf, uc);
            var calculator = new SimpleUseCasePointCalculator();
            UseCasePoints = calculator.CalculateUseCasePoints(project);
        }

        private void CreateTechnicalFactors()
        {
            TechnicalFactors = new List<ComplexityFactorViewModel> {
                new ComplexityFactorViewModel(new AdditionalUsersTrainingCF()),
                new ComplexityFactorViewModel(new ConcurrencyCF()),
                new ComplexityFactorViewModel(new DistributedSystemCF()),
                new ComplexityFactorViewModel(new EasyToInstallCF()),
                new ComplexityFactorViewModel(new EasyToModifyCF()),
                new ComplexityFactorViewModel(new EasyToUseCF()),
                new ComplexityFactorViewModel(new EndUserPerformanceCF()),
                new ComplexityFactorViewModel(new ExternalLibsDependencyCF()),
                new ComplexityFactorViewModel(new InternalCalculationComplexityCF()),
                new ComplexityFactorViewModel(new PerformanceCF()),
                new ComplexityFactorViewModel(new PortabilityCF()),
                new ComplexityFactorViewModel(new ReUsabilityCF()),
                new ComplexityFactorViewModel(new SpecialProtectionCF())
            };
        }

        private void CreateEnviromentFactors()
        {
            EnviromentFactors = new List<ComplexityFactorViewModel> {
                new ComplexityFactorViewModel(new AnalyticsSkillCF()),
                new ComplexityFactorViewModel(new ExpirienceCF()),
                new ComplexityFactorViewModel(new HalfTimeEmployeesPartCF()),
                new ComplexityFactorViewModel(new MethodologyKnowlegdeCF()),
                new ComplexityFactorViewModel(new ObjectOrientedTechniqueKnowledgeCF()),
                new ComplexityFactorViewModel(new ProgrammingLangComplexity()),
                new ComplexityFactorViewModel(new RequirementsStabilityCF()),
                new ComplexityFactorViewModel(new TeamMotivationCF())
            };
        }
    }
}