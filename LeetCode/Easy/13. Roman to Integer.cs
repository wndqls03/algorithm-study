public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> a = new Dictionary<char, int>();
        a['I'] = 1;
        a['V'] = 5;
        a['X'] = 10;
        a['L'] = 50;
        a['C'] = 100;
        a['D'] = 500;
        a['M'] = 1000;

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int cur = a[s[i]];
            if (i < s.Length - 1 && cur < a[s[i + 1]])
            {
                result -= cur;
            }
            else
            {
                result += cur;
            }
        }
        return result;
    }
}