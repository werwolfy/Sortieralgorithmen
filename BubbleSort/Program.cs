using System.Diagnostics;
using ItemsToSort;

NumbersProvieder numbersProvieder = new NumbersProvieder();
List<int> listToSort = numbersProvieder.CreateList(100_000);
BubbleSort.BubbleSort bubbleSort = new();
Stopwatch sw = new Stopwatch();
sw.Start();
bubbleSort.Sort(listToSort);
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);
