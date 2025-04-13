using System.Text;

namespace SolutionFolder;

internal class Identifier
{
    public static string Clean(string identifier)
    {
        var result = new StringBuilder();
        bool capitalizeNext = false;

        foreach (var ch in identifier)
        {
            if (char.IsWhiteSpace(ch))
            {
                result.Append('_');
            }
            else if (char.IsControl(ch))
            {
                result.Append("CTRL");
            }
            else if (ch == '-')
            {
                capitalizeNext = true;
            }
            else if (char.IsLetter(ch) && (ch < 'α' || ch > 'ω'))
            {
                if (capitalizeNext)
                {
                    result.Append(char.ToUpper(ch));
                    capitalizeNext = false;
                }
                else
                {
                    result.Append(ch);
                }
            }
        }

        return result.ToString();
    }

}
