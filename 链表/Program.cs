using System;
using System.Collections.Generic;

namespace 链表
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /*
         * 剑指 Offer 24. 反转链表
        定义一个函数，输入一个链表的头节点，反转该链表并输出反转后链表的头节点。
        示例:

        输入: 1->2->3->4->5->NULL
        输出: 5->4->3->2->1->NULL
         */
        public ListNode ReverseList(ListNode head)
        {
            ListNode pre = null;
            ListNode cur = head;
            ListNode next = null;

            while (cur!=null)
            {
                next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }

            return pre;
        }
    }
}
