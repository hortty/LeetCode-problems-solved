// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/

public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        int j = 0;
        var aux = -9465;

        for (int i = 0; i < nums.Length; i++)
        {
            if (aux != nums[i])
            {
                nums[j] = nums[i];
                j++;
            }
            aux = nums[i];
        }

        return j;
    }
}