using System;
using System.Windows.Threading;

namespace WpfPlanetSimulation.ViewModel
{
  public class MainViewModel : ViewModelBase
  {
    private DispatcherTimer _timer = new(DispatcherPriority.Normal);

    public MainViewModel()
    {
      _timer.Interval = TimeSpan.FromMilliseconds(10);
      _timer.Tick += Timer_Tick;
      _timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
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
