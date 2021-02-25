using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStackGenericsExample
{
    class Stack<T>
    {
        private int size;        // текущий размер стека
        private List<T> data;    // данные стека

        // конструктор
        public Stack()
        {
            data = new List<T>();
            size = 0;
        }

        // Метод добавление нового элемента
        public void Push(T item)
        {
            data.Add(item);
            size++;
        }

        // Метод извлечение элемента
        public T Pop()
        {
            T item = data.LastOrDefault();
            data.Remove(item);
            size--;
            return item;
        }

        // чтение главного элемента стека без удаления
        public T Peek()
        {
            // если данных нет и Стек пуст то выбрасываем исключение
            if (size <= 0)
            {
                throw new Exception("Stack is empty");
            }

            return data [size -1];

        }

        // Метод очистки данных Стека
        public void Clear() 
        {
            data.Clear();
        }

    }
}
