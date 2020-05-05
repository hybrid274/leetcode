public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Trim().Split(' ');
        string finalString = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (!string.IsNullOrEmpty(words[i]))
                finalString = string.Join(" ", finalString, words[i]);
        }
        return finalString.Trim();
    }
}
