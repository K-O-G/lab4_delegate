using System;
using System.Linq;

namespace lab4_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack<int> stack = new CStack<int>();
            stack.Push(3);
            stack.Push(18);
            Console.WriteLine("element Number " + stack.Count.ToString() + " is " + stack.Pop().ToString());
            Console.WriteLine("element Number " + stack.Count.ToString() + " is " + stack.Pop().ToString());
            Console.ReadKey();
        }
    }

}
