using System.Collections;

namespace Test;

public class Node<T>{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data){
        Data = data;
        Next = null;
    }
}

class NLinkedList<T> : IEnumerable<T> {
    private Node<T> head;

    public void Add(T data) {
        Node<T> newNode = new Node<T>(data);

        if (head == null) {
            head = newNode;
        } else {
            Node<T> current = head;
            while (current.Next != null){
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
    
    
    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator(){
        return GetEnumerator();
    }
}

/*
class Program {
    static void Main(){
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);

        Console.WriteLine("Iterating using foreach should work:");
        foreach (var item in linkedList){
            Console.WriteLine(item);
        }
    }
}
Iterator für Linked List
Version 1 mit yield: 
    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator(){
        return GetEnumerator();
    }

Implementierung LinkedListIterator-Klasse: 
class Program {
    static void Main() {
…
        Console.WriteLine("Iterating through LinkedList using foreach:");
        foreach (var item in linkedList)  {
            Console.WriteLine(item);
        }
    }
}
class Node<T> {
    …
}

class LinkedList<T> : IEnumerable<T> {
    private Node<T> head;

    public void Add(T data)     {
        …
    }
    public IEnumerator<T> GetEnumerator()     {
        return new LinkedListEnumerator(head);
    }
    IEnumerator IEnumerable.GetEnumerator()    {
        return GetEnumerator();
    }
}

    private class LinkedListEnumerator : IEnumerator<T> {
        private Node<T> head;
        private Node<T> current;

        public LinkedListEnumerator(Node<T> head) {
            this.head = head;
            this.current = null;
        }

        public T Current => current.Data;

        object IEnumerator.Current => Current;

        public void Dispose() {
            // Dispose, falls notwendig
        }

        public bool MoveNext(){
            if (current == null){
                current = head;
            } else {
                current = current.Next;
            }
            return current != null;
        }

        public void Reset() {
            current = null;
        }
    }
    */
