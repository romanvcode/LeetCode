namespace Solutions
{
    public class MergeAlternatelySolution
    {
        public static string MergeAlternately(string word1, string word2)
        {
            int n1 = word1.Length;
            int n2 = word2.Length;

            int n = n1 < n2 ? n1 : n2;

            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += word1[i];
                result += word2[i];
            }

            if (n1 < n2)
            {
                result += word2[n1..];
            }
            else if (n2 < n1)
            {
                result += word1[n2..];
            }

            return result;
        }
    }
}
