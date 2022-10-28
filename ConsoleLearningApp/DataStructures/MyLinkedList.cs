namespace ConsoleLearningApp.DataStructures
{
    public class MyDoublyLinkedList
    {
        private Node? First { get; set; }

        public void InsertFirst(object data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            First.Prev = newNode;
            newNode.Next = First;
            First = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = First;
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Node current = First;
            string printString = "[ ";
            while(current != null)
            {
                printString += $"{current.Data}, ";
                current = current.Next;
            }
            printString = printString.Remove(printString.Length - 2);
            Console.WriteLine(printString+" ]");
        }

        public void InsertLast(object data)
        {
            Node current = First;
            if (current == null)
            {
                Node firstNode = new Node();
                firstNode.Data = data;
                First = firstNode;
                return;
            }
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Prev = current;
            current.Next = newNode;
        }
    }
    public class Node
    {
        public object Data { get; set; }
        public Node? Next { get; set; }
        public Node? Prev { get; set; }
        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
   
}
