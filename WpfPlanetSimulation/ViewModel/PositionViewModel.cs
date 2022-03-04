using System;

namespace WpfPlanetSimulation.ViewModel
{
  public class PositionViewModel : ViewModelBase
  {
    private int _degrees;
    private double _radius = 150;

    public PositionViewModel()
    {
      CalculateXAndY();
    }
    

    public double X { get; private set; }
    public double Y { get; private set; }

    public double Radius
    {
      get => _radius;
      set
      {
        _radius = value;
        CalculateXAndY();
        RaisePropertyChanged(nameof(Radius));
      }
    }

    public int Degrees
    {
      get => _degrees;
      set
      {
        _degrees = value;
        CalculateXAndY();
        RaisePropertyChanged(nameof(Degrees));
      }
    }

    private void CalculateXAndY()
    {
      var angle = (Math.PI / 180) * Degrees;

      X = Radius * Math.Cos(angle) + Radius;
      Y = Radius * Math.Sin(angle) + Radius;
      RaisePropertyChanged(nameof(X));
      RaisePropertyChanged(nameof(Y));
    }
  }
}
