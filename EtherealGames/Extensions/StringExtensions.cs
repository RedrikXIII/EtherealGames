namespace EtherealGames.Extensions
{
    public static class StringExtensions
    {
        public static string MakeCapital(this string text)
        {
            string res = text[0].ToString().ToUpper();
            for (int i = 1; i < text.Length; i++)
                res += text[i];
            return res;
        }
    }
}
