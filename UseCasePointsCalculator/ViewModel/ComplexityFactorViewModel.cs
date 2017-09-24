using GalaSoft.MvvmLight;
using UseCasePointsCalculator.BusinessLogic;

namespace UseCasePointsCalculator.ViewModel
{
    public class ComplexityFactorViewModel : ViewModelBase
    {
        public IComplexityFactor ComplexityFactor { get; }

        public double FactorValue
        {
            get
            {
                return ComplexityFactor?.Value ?? 0;
            }

            set
            {
                if (ComplexityFactor != null)
                    ComplexityFactor.Value = value;

                RaisePropertyChanged();
            }
        }

        public ComplexityFactorViewModel(IComplexityFactor complexityFactor)
        {
            this.ComplexityFactor = complexityFactor;
        }
    }
}
