public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1;
        var result = 0;

        while (l <= r)
        {
            var area = (r - l) * Math.Min(heights[l], heights[r]);
            result = Math.Max(result, area);

            if (heights[l] <= heights[r])
            {
                ++l;
            }
            else
            {
                --r;
            }
        }

        return result;
    }
}
