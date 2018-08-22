namespace LeetCode
{
	using System;
	using System.Linq;

	/// <summary>
	/// Container With Most Water
	/// https://leetcode.com/problems/container-with-most-water/description/
	/// </summary>
	public class Problem11
	{

		/// <summary>
		/// Time:   O(N)
		/// Memory: O(1)
		/// </summary>
		public int MaxArea(int[] h) {
			if (h.Length < 2) {
				return 0;
			}
			int maxHeight = h.Max();
			int l = 0;
			int r = h.Length - 1;
			int maxArea = (r - l) * Math.Min(h[l], h[r]);
			void AdvanceLeftIx() {
				int currentHeight = h[l];
				int newHeight = h[++l];
				while (newHeight <= currentHeight) {
					newHeight = h[++l];
				}
			}
			void AdvanceRightIx() {
				int currentHeight = h[r];
				int newHeight = h[--r];
				while (newHeight <= currentHeight) {
					newHeight = h[--r];
				}
			}
			void UpdateMaxArea() {
				int currentArea = (r - l) * Math.Min(h[l], h[r]);
				maxArea = Math.Max(maxArea, currentArea);
			}

			while (h[l] < maxHeight && h[r] < maxHeight) {
				if (h[l] <= h[r]) {
					AdvanceLeftIx();
				} else {
					AdvanceRightIx();
				}
				UpdateMaxArea();
			}

			if (h[l] == maxHeight) {
				while (h[r] < maxHeight) {
					AdvanceRightIx();
					UpdateMaxArea();
				}
			} else {
				while (h[l] < maxHeight) {
					AdvanceLeftIx();
					UpdateMaxArea();
				}
			}
			return maxArea;
		}

	}

}
