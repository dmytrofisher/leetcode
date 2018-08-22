namespace LeetCode.Tests
{
	using LeetCode;
	using NUnit.Framework;

	[TestFixture]
	public class Problem3Tests
	{

		[Test]
		public void Test1() {
			// Arrage
			string s = "abcabcbb";
			int expected = 3;

			// Act
			int actual = new Problem3().LengthOfLongestSubstring(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Test2() {
			// Arrage
			string s = "bbbbb";
			int expected = 1;

			// Act
			int actual = new Problem3().LengthOfLongestSubstring(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Test3() {
			// Arrage
			string s = "pwwkew";
			int expected = 3;

			// Act
			int actual = new Problem3().LengthOfLongestSubstring(s);

			// Assert
			Assert.AreEqual(expected, actual);
		}

	}

}
