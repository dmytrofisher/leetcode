namespace LeetCode
{

	/// <summary>
	/// Add Two Numbers
	/// https://leetcode.com/problems/add-two-numbers/description/
	/// </summary>
	public class Problem2
	{

		public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
			return AddTwoNumbersAcc(l1, l2, 0);
		}

		private ListNode AddTwoNumbersAcc(ListNode l1, ListNode l2, int next) {
			if (l1 == null && l2 == null) {
				return next == 0 ? null : new ListNode(next);
			}
			int digit = (l1?.Val ?? 0) + (l2?.Val ?? 0) + next;
			var l = new ListNode(digit % 10) {
				Next = AddTwoNumbersAcc(l1?.Next, l2?.Next, digit / 10)
			};
			return l;
		}

	}

}
