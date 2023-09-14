using System;

namespace QueueClass 
{
    public class Queue 
    {
        int end = 0;
        static int lenght = 100;
        int[] queue = new int[lenght];
        
        public bool Enqueue(int valor)
        {
            queue[end]=valor;
            end++;
            return true;
        }
        public void Peek()
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
    }
}