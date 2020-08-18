using System;
using System.Linq;

namespace Algoritmos
{
    public class StackAlgorithm
    {
        private int[] Arr;
        private int Top;
        private int Capacity;

        public StackAlgorithm(int size)
        {
            Arr = new int[size];
            Capacity = size;
            Top = -1;
        }

        public bool IsEmpty()
        {
            if (Top == -1)
            {
                return true;
            }

            return false;
        }

        public bool IsFull()
        {
            if (Top == Capacity - 1)
            {
                return true;
            }

            return false;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Is full");
                return;
            }

            Top++;

            Arr[Top] = value;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Is Empty");
                return;
            }

            Console.WriteLine($"Elemento deletado {Arr[Top]}");

            Top--;
        }

        public string Size()
        {
            return $"Tamanho da pilha {Top + 1}";
        }

        public void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Vazia!!!");
                return;
            }

            for (var i = 0; i <= Top; i++)
            {
                Console.WriteLine($"Elemento {i + 1} : {Arr[i]}\n");
            }
        }
    }
}
