public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> map = new HashSet<char>();
        int left = 0;
        int result = 0;
        for(int right = 0; right<s.Length; right++)
        {
            while (map.Contains(s[right]))
            {
                map.Remove(s[left]);
                left++;
            }
            map.Add(s[right]);
            result = Math.Max(result, right - left + 1);
        }
        return result;
    }
}