using System;

namespace StackClass
{
    public class Stack
    {
        static int MAX = 1000;
        int top = -1;
        int[] stack = new int[MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }

            top += 1;
            stack[top] = data;
            return true;
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }

            int valor = stack[top];
            top -= 1;
            return valor;
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine($"O topo da pilha é: {stack[top]}");
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            Console.WriteLine("Itens da pilha:");
            for (int i = top; i >= 0; i--)
            {
                string texto = $"Stack[{stack[i]}]";
                Console.WriteLine(texto);
            }

        }
    }
}

