namespace LeetCode
{
	using System.Collections.Generic;

	/// <summary>
	/// Two Sum
	/// https://leetcode.com/problems/two-sum/description/
	/// </summary>
	public class Problem1
	{

		public int[] TwoSum(int[] nums, int target) {
			var complements = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++) {
				int num = nums[i];
				if (complements.ContainsKey(num)) {
					return new int[] { complements[num], i };
				} else if (!complements.ContainsKey(target - num)) {
					complements.Add(target - num, i);
				}
			}
			return new int[] { };
		}

	}

}
