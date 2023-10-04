using System;

namespace QueueClass 
{
    public class Queue 
    {
        int end = 0;
        static int lenght = 100;
        int[] queue = new int[lenght];
        int tamanho=0;
        
        public bool Enqueue(int valor)
        {
            queue[end]=valor;
            end++;
            return true;
        }
        public void PeekStart()
        {
            Console.WriteLine($"O início da fila é: {queue[0]}");
        }    
        public void PeekEnd()
        {
            Console.WriteLine($"O final da fila é: {queue[end-1]}");
        }
        public void Print()
        {
            for (int i = 0; i < end; i++)
            {
                Console.Write("["+queue[i]+"]");
            }
            Console.WriteLine("");
        }
        public void Comprimento()
        {
            for (int i = 1; i < Queue.lenght; i++)
            {
                if (queue[i]==0)
                {
                    i=Queue.lenght;
                }
                tamanho++;
            }
            Console.WriteLine($"O tamanho da fila é: {tamanho}");
        }
    }
}