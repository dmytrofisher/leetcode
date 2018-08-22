namespace LeetCode.Tests
{
	using LeetCode;
	using NUnit.Framework;

	[TestFixture]
	public class Problem11Tests
	{

		[Test]
		public void Test1() {
			// Arrage
			int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
			int expected = 49;

			// Act
			int actual = new Problem11().MaxArea(heights);

			// Assert
			Assert.AreEqual(expected, actual);
		}

	}

}
