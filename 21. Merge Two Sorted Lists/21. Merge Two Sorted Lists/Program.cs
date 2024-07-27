using _21._Merge_Two_Sorted_Lists;

//var list4 = new ListNode(5);
//var list3 = new ListNode(4, list4);
var list2 = new ListNode(4);
var list1 = new ListNode(2, list2);
var list = new ListNode(1, list1);


//var list9 = new ListNode(10);
//var list8 = new ListNode(9, list9);
var list7 = new ListNode(4);
var list6 = new ListNode(3, list7);
var list5 = new ListNode(1, list6);


MergeTwoLists(list, list5);


ListNode MergeTwoLists(ListNode list1, ListNode list2)
{
    ListNode head = new ListNode(0);
    ListNode current = head;

    while (list1 != null && list2 != null)
    {
        ListNode newNode;

        if (list1.val < list2.val)
        {
            current.next = list1;
            list1 = list1.next;
        }
        else
        {
            current.next = list2;
            list2 = list2.next;
        }
        current = current.next;
    }

    if (list1 != null)
    {
        current.next = list1;
    }
    else
    {
        current.next = list2;
    }

    return head.next;
}