using System.Windows;
using WpfPlanetSimulation.ViewModel;

namespace WpfPlanetSimulation
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      DataContext = new MainViewModel();
    }


  }
}
