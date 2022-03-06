using System;

namespace WpfPlanetSimulation.ViewModel
{
  public class PositionViewModel : ViewModelBase
  {
    private double _degrees;
    private double _radius = 150;
    private double _centerX;
    private double _centerY;

    public PositionViewModel()
    {
      CalculateXAndY();
    }

    public double X { get; private set; }
    public double Y { get; private set; }

    public double CenterX
    {
      get => _centerX;
      set
      {
        _centerX = value;
        CalculateXAndY();
        RaisePropertyChanged(nameof(CenterX));
      }
    }
    
    public double CenterY
    {
      get => _centerY;
      set
      {
        _centerY = value;
        CalculateXAndY();
        RaisePropertyChanged(nameof(CenterY));
      }
    }

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

    public double Degrees
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

      X = Radius * Math.Cos(angle) + CenterX;
      Y = Radius * Math.Sin(angle) + CenterY;
      RaisePropertyChanged(nameof(X));
      RaisePropertyChanged(nameof(Y));
    }
  }
}
