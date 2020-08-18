
using System;

namespace Algoritmos
{
    public class QueueAlgorithm
    {
        private int[] Fila { get; set; }
        private int Tamanho = 5;
        private int Front;
        private int Rear;

        public QueueAlgorithm()
        {
            Fila = new int[Tamanho];
            Front = -1;
            Rear = -1;
        }

        private bool IsFull()
        {
            if (Rear == Tamanho-1)
            {
                return true;
            }

            return false;
        }

        private bool IsEmpty()
        {
            if (Rear == -1 && Front == -1)
            {
                return true;
            }

            return false;
        }

        public int Peek()
        {
            return Fila[Front];
        }

        public void Enqueue(int valor)
        {
            if (IsFull())
            {
                Console.WriteLine("Fila está cheia!!!");
            }

            if (Front == -1)
            {
                Front = 0;
            }

            Rear++;

            Fila[Rear] = valor;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila está vazia!!");
            }

            var data = Peek();
            //
            if (Front >= Rear)
            {
                Front = -1;
                Rear = -1;
                return;
            }

            Front++;

            Console.WriteLine($"Elemento deletado: {data}");

        }
    }
}
