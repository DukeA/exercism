namespace SolutionFolder;

internal class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        bool isQuestion = statement.EndsWith("?");
        bool isYelling = statement.Any(char.IsLetter) && statement.ToUpper() == statement && statement.ToLower() != statement;

        if (isYelling && isQuestion)
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (isYelling)
        {
            return "Whoa, chill out!";
        }
        else if (isQuestion)
        {
            return "Sure.";
        }

        return "Whatever.";
    }
}
