public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1;
        var result = 0;

        while (l < r)
        {
            var prod = (r - l) * Math.Min(heights[l], heights[r]);
            result = Math.Max(result, prod);
                
            if (heights[l] > heights[r])
            {
                --r;
            } 
            else
            {
                ++l;
            }
        }

        return result;
    }
}
