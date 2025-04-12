﻿namespace SolutionFolder;

internal class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
            return 0;
        if (speed >= 1 && speed <= 4)
            return 1.0;
        if (speed >= 5 && speed <= 8)
            return 0.9;
        if (speed == 9)
            return 0.8;
        if (speed == 10)
            return 0.77;
        return 0.0;
    }


    public static double ProductionRatePerHour(int speed) => speed * 221.0 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);

}

