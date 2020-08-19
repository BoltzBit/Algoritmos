using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackAlgorithm pilha = new StackAlgorithm(6);

            //pilha.Push(5);
            //pilha.Push(6);
            //pilha.Push(7);

            //pilha.PrintStack();

            //pilha.Push(4);
            //pilha.Push(6);
            //pilha.Push(3);

            ////mensagem está cheia
            //pilha.Push(6);

            //pilha.PrintStack();

            //pilha.Pop();
            //pilha.Pop();
            //pilha.Pop();

            //pilha.PrintStack();

            //pilha.Pop();
            //pilha.Pop();
            //pilha.Pop();

            ////mensagem está vazia
            //pilha.Pop();


            //pilha.PrintStack();

            CircularQueue circular = new CircularQueue();
            Random number = new Random();

            for (var i = 0;i < 10;i++)
            {
                if (!circular.IsFull())
                {
                    circular.Enqueue(number.Next(2, 32));
                }
            }

            circular.PrintCircularQueue();

            circular.Enqueue(9);

            var l = 0;

            while (l <= 5)
            {
                circular.Dequeue();
                l++;
            }

            circular.Dequeue();

            circular.PrintCircularQueue();

        }
    }
}
