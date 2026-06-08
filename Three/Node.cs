namespace Three;

public class Node<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data) {
            Data = data;
        }

        public override string ToString() {
            return this.Data.ToString();
        }
    }

public class GenericTree<T> where T : IComparable<T>
{
    public Node<T> Root { get; private set; }

    public GenericTree()
    {
        Root = null;
    }

    public int GetDepth()
    {
        if (Root == null)
            return -1;
        else
            return GetDepth(Root);
    }

    private int GetDepth(Node<T> node)
    {
        if (node == null)
        {
            return -1;
        }
        else
        {
            /* compute the depth of each subtree */
            int lDepth = GetDepth(node.Left);
            int rDepth = GetDepth(node.Right);

            /* use the larger one */
            if (lDepth > rDepth)
                return (lDepth + 1);
            else return (rDepth + 1);
        }
    }

    public Node<T> FindRec(T item)
    {
        if (Root != null)
        {
            return FindRec(item, Root);
        }
        return null;
    }

    public Node<T> FindRec(T item, Node<T> temp)
    {
        switch (item.CompareTo(temp.Data))
        {
            case 0: return temp;
            case -1:
                if (temp.Left != null)
                    return FindRec(item, temp.Left);
                break;
            case 1:
                if (temp.Right != null)
                    return FindRec(item, temp.Right);
                break;
        }

        return null;
    }

    public T FindMin()
    {
        if (Root == null)
        {
            throw new InvalidOperationException("The tree is empty");
        }

        return FindMinRecursive(Root).Data;
    }

    public Node<T> FindMinRecursive(Node<T> node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }

        return node;
    }

    public T FindMax()
    {
        if (Root == null)
        {
            throw new InvalidOperationException("The tree is empty");
        }

        return FindMaxRecursive(Root).Data;
    }

    public Node<T> FindMaxRecursive(Node<T> node)
    {
        while (node.Right != null)
        {
            node = node.Right;
        }

        return node;
    }
}

