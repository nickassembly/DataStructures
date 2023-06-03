
using DataStructures.ArrayMethods;
using DataStructures.BinarySearchTree;
using DataStructures.LinkedList;
using DataStructures.Queue;
using DataStructures.Stack;

// LinkedList
//LinkedList myLinkedList = new LinkedList();
//myLinkedList.InsertFirst(1);
//myLinkedList.InsertFirst(2);
//myLinkedList.InsertFirst(3);
//myLinkedList.InsertFirst(4);

//myLinkedList.DeleteFirst();
//myLinkedList.DeleteFirst();

//myLinkedList.InsertLast(546);
//myLinkedList.InsertLast(123);

//myLinkedList.DisplayList();


//Stack stack = new Stack(10);

//for(int i = 0; i < 3; i++)
//{
//    stack.Push("Item1");
//    stack.Push("Item2");
//    stack.Push("Item3");
//}

//stack.Pop();
//stack.Peek();

//while(!stack.isEmpty())
//{
//    var value = stack.Pop();
//    Console.WriteLine(value);
//}

//Queue queue = new Queue(10);
//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);

//queue.Dequeue();
//queue.Dequeue();

//queue.Peek();

// Binary search tree

//BinarySearchTree bst = new BinarySearchTree();
//bst.Insert(7, "Squirtle");
//bst.Insert(23, "Ekans");
//bst.Insert(151, "Mew");
//bst.Insert(4, "Charmander");
//bst.Insert(1, "Bulbasaur");

//Console.WriteLine(bst.Find(151));

//int value = 0;

int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };

Console.WriteLine(BubbleSort(intArray));
int[] value = BubbleSort(intArray);

int[] BubbleSort(int[] array)
{
    int temp = 0;

    for (int pointer = 0; pointer < array.Length; pointer++)
    {
        for (int sort = 0; sort < array.Length - 1; sort++)
        {
            if (array[sort] > array[sort + 1])
            {
                temp = array[sort + 1];
                array[sort + 1] = array[sort];
                array[sort] = temp;
            }
        }
    }

    return array;
}
