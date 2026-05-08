public class Solution {
	public List<List<string>> GroupAnagrams(string[] strs) {
		var map = new Dictionary<string, List<string>> { { SortString(strs[0]), new List<string>{strs[0]} } };
		var result = new List<List<string>>();

		for (var i = 1; i < strs.Length; i++)
		{
			var key = SortString(strs[i]);

			if (!map.ContainsKey(key))
			{
				map[key] = new List<string> { strs[i] };

				continue;
			}

			map[key].Add(strs[i]);
		}

		foreach (var value in map.Values)
		{
			result.Add(value);
		}

		return result;
	}

	private string SortString(string str)
	{
		char[] chars = str.ToCharArray();
        
		Array.Sort(chars);
            
		return new string(chars);
	}
}