namespace ConsoleLearningApp.DataStructures
{
    public class MyQueue
    {
        public int MaxSize { get; set; }
        private object[] QueueArray { get; set; }
        public int Rear { get; set; }
        public int Front { get; set; }
        public int Length { get; set; }
        public MyQueue(int size)
        {
            this.MaxSize = size;
            this.QueueArray = new object[size];
            Rear = -1;
            Front = 0;
            Length = 0;
        }
        public void Enqueue(object item)
        {
            if (Rear == MaxSize - 1)
            {
                Rear = -1;
            }
            if ((Length > 0) && (Rear == Front-1))
            {
                Console.WriteLine("Queue is full");
                return;
            }
            Rear++;
            QueueArray[Rear] = item;
            Length++;
        }
        public void Dequeue()
        {
            QueueArray[Front] = null;
            Front++;
            Length--;
        }

        public object Peek()
        {
            return QueueArray[Front];
        }

    }
}
