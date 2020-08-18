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

            QueueAlgorithm fila = new QueueAlgorithm();

            fila.Enqueue(5);
            fila.Enqueue(6);
            fila.Enqueue(7);
            fila.Enqueue(8);
            fila.Enqueue(14);
            fila.Enqueue(60);

            
        }
    }
}
