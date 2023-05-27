
Console.WriteLine("Hello, Keller!");


// adding a linked list of strings
var linkedList = new LinkedList<string>();
linkedList.AddLast("Hello");
linkedList.AddLast("Keller");
linkedList.AddLast("!");

foreach (var item in linkedList)
{
    Console.WriteLine(item);
}
