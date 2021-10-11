using System;
public class ReplacedString
{
    private string replacedString;

    public ReplacedString(string s, string initialSubstring, string finalSubstring)
    {
        
        while (s != s.Replace(initialSubstring, finalSubstring))

        {
            if (s.Contains(initialSubstring))
            {
                s=s.Replace(initialSubstring, finalSubstring);
            }
            else
            {
                break;
            }
        }
        replacedString = s;

    }

    public override string ToString()
    {
        return replacedString;
    }
}