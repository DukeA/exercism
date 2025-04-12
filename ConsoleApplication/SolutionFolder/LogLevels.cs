namespace SolutionFolder;

internal class LogLevels
{
    public static string Message(string logLine) =>
         logLine.Split(new[] { ": " }, 2, StringSplitOptions.None)[1].Trim();

    public static string LogLevel(string logLine) =>
        logLine.Split(new[] { ": " }, 2, StringSplitOptions.None)[0].Trim('[', ']').ToLower();

    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";
}
