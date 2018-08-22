namespace LeetCode
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Longest Substring Without Repeating Characters
	/// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
	/// </summary>
	public class Problem3
	{

		public int LengthOfLongestSubstring(string s) {
			if (s.Length == 0) {
				return 0;
			}
			char[] chars = s.ToCharArray();
			int longestSeq = 1;
			int currentSeq = 1;
			var accumulatedChars = new Dictionary<char, int> { { chars[0], 0 } };
			int i = 1;
			while (i < chars.Length) {
				char currentChar = chars[i];
				if (accumulatedChars.ContainsKey(currentChar)) {
					i = accumulatedChars[currentChar] + 1;
					accumulatedChars = new Dictionary<char, int> { { chars[i], i } };
					longestSeq = Math.Max(longestSeq, currentSeq);
					currentSeq = 1;
				} else {
					accumulatedChars.Add(currentChar, i);
					currentSeq++;
				}
				i++;
			}
			return Math.Max(longestSeq, currentSeq);
		}

	}

}
