using _83._Remove_Duplicates_from_Sorted_List;

var list9 = new ListNode(4);
var list4 = new ListNode(3, list9);
var list3 = new ListNode(3, list4);
var list2 = new ListNode(2, list3);
var list1 = new ListNode(1, list2);
var list = new ListNode(1, list1);


var list11 = new ListNode();

//var list9 = new ListNode(10);
//var list8 = new ListNode(9, list9);
var list7 = new ListNode(4);
var list6 = new ListNode(3, list7);
var list5 = new ListNode(1, list6);

var a = DeleteDuplicates(list);

ListNode DeleteDuplicates(ListNode head)
{
    if (head == null)
    {
        return null;
    }
    ListNode current = head;

    while (current.next != null)
    {
        if (current.val == current.next.val)
            current.next = current.next.next;
        else
            current = current.next;
    }

    return head;
}