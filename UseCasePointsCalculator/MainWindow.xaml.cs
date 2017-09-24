using System.Windows;
using UseCasePointsCalculator.ViewModel;

namespace UseCasePointsCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void btnAddActor_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            var dc = this.DataContext as MainViewModel;
            dc.AddActorVM = new AddActorViewModel(dc);
            this.gridAddActor.Visibility = Visibility.Visible;
        }

        private void btnAddUseCase_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            var dc = this.DataContext as MainViewModel;
            dc.AddUseCaseVM = new AddUseCaseViewModel(dc);
            this.gridAddUseCase.Visibility = Visibility.Visible;
        }

        private void btnAddActorAccept_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            var dc = this.DataContext as MainViewModel;

            if (dc.AddActorVM == null)
            {
                return;
            }

            dc.AddActorVM.AddActor();
            dc.AddActorVM = null;
            this.gridAddActor.Visibility = Visibility.Collapsed;
        }

        private void btnAddActorDenied_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            this.gridAddActor.Visibility = Visibility.Collapsed;
        }

        private void btnAddUseCaseAccept_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            var dc = this.DataContext as MainViewModel;

            if (dc.AddUseCaseVM == null)
            {
                return;
            }

            dc.AddUseCaseVM.AddUseCase();
            dc.AddUseCaseVM = null;
            this.gridAddUseCase.Visibility = Visibility.Collapsed;
        }

        private void btnAddUserCaseDenied_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            this.gridAddUseCase.Visibility = Visibility.Collapsed;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            var dc = this.DataContext as MainViewModel;
            dc.Calculate();
        }
    }
}
