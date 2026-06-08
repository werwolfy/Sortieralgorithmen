

using Test;

NLinkedList<int> linkedList = new NLinkedList<int>();
linkedList.Add(1);
linkedList.Add(2);
linkedList.Add(3);

Console.WriteLine("Iterating using foreach should work:");
foreach (var item in linkedList){
    Console.WriteLine(item);
}
