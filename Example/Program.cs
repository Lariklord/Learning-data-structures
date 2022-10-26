using Example;

//MyLinkedListExample();
//MyDoubleLinkedListExample();
//MyStackOnArrayExample();
//MyStackOnLinkedListExample();
MyQueueExample();

void MyLinkedListExample()
{
    MyLinkedList<string> list = new MyLinkedList<string>();
    list.Add("Vlad");
    list.Add("Vanya");
    list.Add("Kostya");
    list.Add("Roma");
    list.Add("Serega");

    foreach (var item in list)
    {
        Console.Write(item+"\t");
    }
    Console.WriteLine();

    list.Remove("Roma");

    foreach (var item in list)
    {
        Console.Write(item + "\t");
    }
    Console.WriteLine();

    Console.WriteLine(list.Contains("Roma"));
    Console.WriteLine(list.Contains("Vlad"));

    list.AppendFirst("Vladik");
    foreach (var item in list)
    {
        Console.Write(item + "\t");
    }
    Console.WriteLine();
}
void MyDoubleLinkedListExample()
{
    MyDoubleLinkedList<string> list = new MyDoubleLinkedList<string>();
    list.Add("Vlad");
    list.Add("Vanya");
    list.Add("Kostya");
    list.Add("Roma");
    list.Add("Serega");

    foreach (var item in list)
    {
        Console.Write(item + "\t");
    }
    Console.WriteLine();

    list.Remove("Roma");

    foreach (var item in list)
    {
        Console.Write(item + "\t");
    }
    Console.WriteLine();

    Console.WriteLine(list.Contains("Roma"));
    Console.WriteLine(list.Contains("Vlad"));

    list.AppendFirst("Vladik");
    foreach (var item in list.BackEnumerator())
    {
        Console.Write(item + "\t");
    }
    Console.WriteLine();
    foreach (var item in list)
    {
        Console.Write(item + "\t");
    }
    Console.WriteLine();
}
void MyStackOnArrayExample()
{
    MyStackOnArray<string> stack = new MyStackOnArray<string>();

    stack.Push("Vlad");
    stack.Push("Vanya");
    stack.Push("Kostya");
    stack.Push("Roma");

    Console.WriteLine(stack.Count);

    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Peek());

    Console.WriteLine(stack.Count);
}
void MyStackOnLinkedListExample()
{
    MyStackOnLinkedList<string> stack = new MyStackOnLinkedList<string>();
    stack.Push("Vlad");
    stack.Push("Vanya");
    stack.Push("Kostya");
    stack.Push("Roma");

    foreach (var el in stack)
    {
        Console.WriteLine(el);
    }

    var item = stack.Peek();
    Console.WriteLine($"\nHeader: {item}\n");

    stack.Pop();
    foreach (var el in stack)
    {
        Console.WriteLine(el);
    }

    Console.WriteLine($"\nSize: {stack.Count}");
}
void MyQueueExample()
{
    MyQueue<string> queue = new MyQueue<string>();
    queue.Enqueue("Vlad");
    queue.Enqueue("Vanya");
    queue.Enqueue("Kostya");
    queue.Enqueue("Roma");
    Console.WriteLine(queue.Count);
    Console.WriteLine(queue.First);
    Console.WriteLine(queue.Last);
    Console.WriteLine(queue.Contains("Vlad"));
    Console.WriteLine();
    foreach (var item in queue)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
    queue.Dequeue();
    foreach (var item in queue)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();

}
