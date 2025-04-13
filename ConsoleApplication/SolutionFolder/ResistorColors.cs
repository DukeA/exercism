namespace SolutionFolder;

internal class ResistorColors
{
    public static string[] Colors()
    {
        return new string[]
        {
            "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"
        };
    }

    public static int Value(string[] colors)
    {
        var colorMap = Colors();
        int firstDigit = Array.IndexOf(colorMap, colors[0]);
        int secondDigit = Array.IndexOf(colorMap, colors[1]);
        return firstDigit * 10 + secondDigit;
    }
}
