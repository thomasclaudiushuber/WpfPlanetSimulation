using System;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfPlanetSimulation.ViewModel
{
  public class MainViewModel : ViewModelBase
  {
    const double degreesChangeMars = 365.0 / 687.0;
    private bool _isAnimated;

    public MainViewModel()
    {
      CompositionTarget.Rendering += CompositionTarget_Rendering;
    }

    private void CompositionTarget_Rendering(object? sender, EventArgs e)
    {
      if (IsAnimated)
      {
        PositionMars.Degrees += degreesChangeMars;
        PositionEarth.Degrees += 1;
        PositionMoon.Degrees += 3;
      }

      PositionMoon.CenterX = PositionEarth.X;
      PositionMoon.CenterY = PositionEarth.Y;
    }

    public PositionViewModel PositionMars { get; } = new() { CenterX = 200, CenterY = 200 };
    public PositionViewModel PositionEarth { get; } = new() { CenterX = 200, CenterY = 200, Radius = 100 };
    public PositionViewModel PositionMoon { get; } = new() { Radius = 30 };


    public bool IsAnimated
    {
      get => _isAnimated;
      set
      {
        _isAnimated = value;
        RaisePropertyChanged(nameof(IsAnimated));
      }
    }
  }
}
