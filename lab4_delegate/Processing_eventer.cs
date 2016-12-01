using System;

namespace lab4_delegate
{
    public class Processing_eventer
    {
        delegate void WorkDetermination(string st, char ch);
        public СStack<string> stack;
        public void InitializationStack()
        {
            Console.WriteLine("Please, input stack size");
            int n = Convert.ToInt32(Console.ReadLine());
            stack = new СStack<string>(n);
            stack.PeekStack += Show_Message;
            stack.PopStack += Show_Message;
            stack.PushStack += Show_Message;
            stack.StackOverflow += Show_Message;
        }
        public void PushData()
        {
            Console.WriteLine("Please, input data");
            string item=Console.ReadLine();
            stack.Push(item);
        }
        public void PopData()
        {
            stack.Pop();
        }
        public void PeekData()
        {
            stack.Peek();
        }
        public void Determination()
        {
            Console.WriteLine("Please, input string");
            string str = Console.ReadLine();
            Console.WriteLine("Please, input char");
            char ch = Convert.ToChar(Console.ReadLine());
            WorkDetermination work = delegate(string st, char a)
            {
                int position = 0;
                position = st.IndexOf(a);
                Console.WriteLine("Position:" + (position+1));
            };
            work(str, ch);
        }


        private static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}