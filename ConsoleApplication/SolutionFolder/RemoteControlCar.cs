namespace SolutionFolder;

internal class RemoteControlCar
{
    private double _distanceDriven;
    private double _batteryLevel = 100.0;
    private const double DistancePerDrive = 20.0;
    private const double BatteryDrainPerDrive = 1.0;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distanceDriven} meters";

    public string BatteryDisplay()
    {
        if (_batteryLevel <= 0)
        {
            return "Battery empty";
        }
        return $"Battery at {Math.Max(0, Math.Round(_batteryLevel, 2))}%";
    }

    public void Drive()
    {
        if (_batteryLevel <= 0)
        {
            return;
        }
        _distanceDriven += DistancePerDrive;
        _batteryLevel -= BatteryDrainPerDrive;
    }
}
