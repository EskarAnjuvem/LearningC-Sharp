using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace LearningGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> integerStack = new Stack<int>(5);
            integerStack.Push(200);
            integerStack.Push(300);
            integerStack.Push(40);
            integerStack.Push(5);
            integerStack.Push(34);

            Console.WriteLine($"Top of integer Stack {integerStack.Peek()}");
            Console.WriteLine($"Initial size: {integerStack.Size()}");
            Console.WriteLine($"Pop the top: {integerStack.Pop()}");
            Console.WriteLine($"Peeking at stack top now: {integerStack.Peek()}");
            Console.WriteLine($"Final size: {integerStack.Size()}");

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Swap<string>(ref a, ref b);

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.ReadLine();

        }

        public static void Swap<K>(ref K first,ref K second)
        {
            K temp = first;
            first = second;
            second = temp;
        }
    }

    public class Stack<T>
    {
        private T[] elements;
        public T number { get; set; }
        private int size;
        private int capacity;

        public Stack(int capacity)
        {
            this.capacity = capacity;
            elements = new T[capacity];
            size = 0;
        }

        public void Push(T element)
        {
            if (size >= capacity)
            {
                throw new InvalidOperationException("Stack Overflow");
            }
            elements[size++] = element;
        }

        public T Pop()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack Underflow");
            }
            return elements[--size];
        }

        public T Peek()
        {
            if (size == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return elements[size - 1];
        }
        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Size()
        {
            return size;
        }
    }

    


}
