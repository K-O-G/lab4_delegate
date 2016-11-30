using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_delegate
{
    public class CStack<T>
    {
        private T[] _array; //массив для хранения данных типа T
        private const int defaultCapacity = 10; //вместимость по умолчанию, потом можно расширить
        private int size; //размер

        public CStack()
        { //конструктор
            size = 0;
            _array = new T[defaultCapacity];
        }

        public bool isEmpty() //проверка на пустоту
        {
            return size == 0;
        }

        public virtual int Count //параметр для вывода размера 
        {
            get
            {
                return size;
            }
        }

        public T Pop() //метод взятия с вершины
        {
            if (size == 0)
            { //вброс ошибки при взятии с пустого стека (Overflow)
                throw new InvalidOperationException();
            }
            return _array[--size];
        }

        public void Push(T newElement)
        {
            if (this.size == _array.Length) //если у нас переполнение...
            { //знаю, что неоптимально, но это c#...
                T[] newArray = new T[2 * _array.Length];
                Array.Copy(_array, 0, newArray, 0, this.size);
                _array = newArray; //просто создаем новый массив с двойным размером
            }
            _array[size++] = newElement; //вставляем элемент
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException();
            }
            return _array[size - 1];
        }
    }


}
