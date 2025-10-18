public class Program 
{ 
    public static void Main(string[] args) 
    {        
        // var result = IsAnagram("anagram", "nagaram"); 
        var result = IsAnagram("rat", "tar"); 
        Console.WriteLine(result);
    }

    public static bool IsAnagram(string s, string t)
    {
        var sizeS = s.Length;
        var sizeT = s.Length;
        var recurrencesS = new Dictionary<char, int>();
        var recurrencesT = new Dictionary<char, int>();

        if (sizeS != sizeT) return false;

        for (int i = 0; i < sizeS; i++)
        {
            if (!recurrencesS.ContainsKey(s[i]))
                recurrencesS.Add(s[i], 1);
            else
                recurrencesS[s[i]] += 1;

            if (!recurrencesT.ContainsKey(t[i]))
                recurrencesT.Add(t[i], 1);
            else
                recurrencesT[t[i]] += 1;
        }

        for (int i = 0; i < recurrencesS.Count; i++)
        {
            if (!recurrencesT.ContainsKey(s[i]))
            {
                return false;
            }

            var countT = recurrencesT[s[i]];
            var countS = recurrencesS[s[i]];

            if (countT != countS)
            {
                return false;
            }
        }

        return true;
    } 
}
