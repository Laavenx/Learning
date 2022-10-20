using ConsoleLearningApp.DataStructures;

namespace ConsoleLearningApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue(5);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Dequeue();
            queue.Enqueue(7);
            queue.Enqueue(8);
        }
    }
}