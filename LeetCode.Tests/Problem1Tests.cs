namespace LeetCode.Tests
{
	using LeetCode;
	using NUnit.Framework;

	[TestFixture]
	public class Problem1Tests
	{
		[Test]
		public void Test1() {
			// Arrage
			int[] nums = { 2, 7, 11, 15 };
			const int target = 9;
			int[] expected = { 0, 1 };

			// Act
			int[] actual = new Problem1().TwoSum(nums, target);

			// Assert
			CollectionAssert.AreEqual(expected, actual);
		}

	}

}
