public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numbers = new List<int>();
        int num;

        for (int i = 0; i < nums.Length; i++) 
        {
           num = nums[i];  

            if (numbers.Contains(num))
            {
                return true;
            }

            numbers.Add(num);
        }

        return false;
    }
}
