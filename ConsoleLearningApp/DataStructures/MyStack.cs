namespace ConsoleLearningApp.DataStructures
{
    public class MyStack
    {
        public int MaxSize { get; set; }
        private object[] StackArray { get; set; }
        public int Top { get; set; }

        public MyStack(int size)
        {
            this.MaxSize = size;
            this.StackArray = new object[MaxSize];
            this.Top = -1;
        }

        public void Push(object item)
        {
            Top++;
            StackArray[Top] = item;
        }

        public object Pop()
        {
            var old_top = Top;
            Top--;
            return StackArray[old_top];
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public void DisplayStack()
        {
            int current = -1;
            while(current < Top)
            {
                Console.WriteLine(StackArray[current+1]);
                current += 1;
            }
        }
    }
}
