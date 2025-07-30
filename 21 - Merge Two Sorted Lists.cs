// https://leetcode.com/problems/merge-two-sorted-lists/description/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode list = null;
        ListNode aux = null;

        while (true)
        {
            if (list1 == null && list2 == null)
                break;

            int biggerVal = CompareLists(ref list1, ref list2);
            AddToList(biggerVal, ref list);
        }

        return list;
    }

    public ListNode AddToList(int value, ref ListNode node)
    {
        if (node == null)
        {
            node = new ListNode(value, null);
            return node;
        }

        if (node.next == null)
        {
            node.next = new ListNode(value, null);
            return node;
        }
        else
        {
            return AddToList(value, ref node.next);
        }
    }

    public int CompareLists(ref ListNode list1, ref ListNode list2)
    {
        int value = 0;

        if (list1 == null)
        {
            value = list2.val;
            list2 = list2.next;
            return value;
        }

        if (list2 == null)
        {
            value = list1.val;
            list1 = list1.next;
            return value;
        }

        if (list1.val < list2.val)
        {
            value = list1.val;
            list1 = list1.next;
        }
        else
        {
            value = list2.val;
            list2 = list2.next;
        }

        return value;
    }
}