public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        /*for(int i = 0; i<nums.Length; i++)
        {
            for(int j = i+1; j<nums.Length; j++)
            {
                if(nums[i]+nums[j] == target)
                {
                    return new int [] {i,j};
                }
            }
        }
        return new int[0];*/
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int need = target - nums[i];
            if (map.ContainsKey(need))
            {
                return new int[] { map[need], i };
            }
            map[nums[i]] = i;
        }
        return new int[0];
    }
}