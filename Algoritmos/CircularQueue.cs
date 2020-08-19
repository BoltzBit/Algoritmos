using System;

namespace Algoritmos
{
    public class CircularQueue
    {
        private int[] Fila { get; set; }
        private int Tamanho = 5;
        private int Front;
        private int Rear;

        public CircularQueue()
        {
            Fila = new int[Tamanho];
            Front = -1;
            Rear = -1;
        }

        public bool IsFull()
        {
            if (Front == 0 && Rear == Tamanho - 1)
            {
                return true;
            }

            if (Front == Rear + 1)
            {
                return true;
            }

            return false;
        }

        public bool IsEmpty()
        {
            if (Front == -1)
            {
                return true;
            }

            return false;
        }

        public void Enqueue(int valor)
        {
            if (IsFull())
            {
                Console.WriteLine("Fila está cheia!");
                return;
            }

            if(IsEmpty())
            {
                Front = 0;
            }

            Rear = (Rear + 1) % Tamanho;

            Fila[Rear] = valor;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila está vazia!");

                return;
            }

            int data = Fila[Front];

            Front = (Front + 1) % Tamanho;

            Console.WriteLine($"Elemento deletado {data}");

            if (Front == Rear)
            {
                Front = -1;
                Rear = -1;

                return;
            }
        }

        public void PrintCircularQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila vazia");
                return;
            }

            foreach (var item in Fila)
            {
                Console.WriteLine($"item: {item}");
            }
        }
    }
}
