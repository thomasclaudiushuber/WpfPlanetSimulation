using System;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfPlanetSimulation.ViewModel
{
  public class MainViewModel : ViewModelBase
  {
    public MainViewModel()
    {
      CompositionTarget.Rendering += CompositionTarget_Rendering;
    }

    private void CompositionTarget_Rendering(object? sender, EventArgs e)
    {
      if (IsAnimated)
      {
        PositionMars.Degrees++;
      }
    }

    public PositionViewModel PositionMars { get; } = new();

    private bool _isAnimated;

    public bool IsAnimated
    {
      get { return _isAnimated; }
      set { _isAnimated = value; }
    }

  }
}
