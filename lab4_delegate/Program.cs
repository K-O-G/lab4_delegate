﻿using System;
using System.Linq;

namespace lab4_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ui u = new ui();
            bool work = true;
            while (work == true)
            {
                u.menu();
                u.casein();
            }
            //    try
            //    {
            //        СStack<string> stack = new СStack<string>(8);
            //        // добавляем четыре элемента
            //        stack.Push("Kate");
            //        stack.Push("Sam");
            //        stack.Push("Alice");
            //        stack.Push("Tom");
            //        stack.Push("A");
            //        stack.Push("B");
            //        stack.Push("C");
            //        stack.Push("D");
            //        //stack.Push("E");
            //        // извлекаем один элемент
            //        var head = stack.Pop();
            //        Console.WriteLine(head);    // Tom

            //        // просто получаем верхушку стека без извлечения
            //        head = stack.Peek();
            //        Console.WriteLine(head);    // Alice
            //    }
            //    catch (InvalidOperationException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }


            //    Console.Read();
            //}
        }
        
    }

}
