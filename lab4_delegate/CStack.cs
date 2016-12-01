using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_delegate
{
    public class СStack<T>
    {
        public delegate void MyStack (string message);
        public event MyStack StackOverflow;
        public event MyStack NullStack;
        public event MyStack PopStack;
        public event MyStack PushStack;
        public event MyStack PeekStack;
        private T[] items; // элементы стека
        private int count;  // количество элементов
        const int n = 10;   // количество элементов в массиве по умолчанию
        public СStack()
        {
            items = new T[n];
        }
        public СStack(int length)
        {
            items = new T[length];
        }
        // пуст ли стек
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        // размер стека
        public int Count
        {
            get { return count; }
        }
        // добавление элемента
        public void Push(T item)
        {
            // если стек заполнен
            if (count == items.Count())
            {
                StackOverflow("Stack Overflowed");
                return;
            }
            items[count++] = item;
            PushStack("Push elmenet: " + item);
        }
        // извлечение элемента
        public T Pop()
        {
            // если стек пуст
            if (IsEmpty)
                NullStack("The stack is empty");
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку
            PopStack("Pop element: " + item);
            return item;
        }
        // возвращаем элемент из верхушки стека
        public T Peek()
        {
            PeekStack("Peek element: " + items[count - 1]);
            return items[count - 1];
        }


    }


}
