using System;
using System.Globalization;

namespace StackClass
{
    public class Stack
    {
        static int MAX = 1000;
        int top = -1;
        string[] stack = new string[MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(string data)
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

        public string Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return "";
            }

            string valor = stack[top];
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
            Console.WriteLine($"O primeiro do monte é: {stack[top]}");
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            int cont = 0;
            Console.WriteLine("Pessoas no monte:");
            for (int i = top; i >= 0; i--)
            {
                string texto = stack[i];
                Console.WriteLine(texto);
                cont++;
            }
            if (cont >= 4)
            {
                Console.WriteLine($"{stack[0]} foi esmagado devido a grande quantidade de pessoas em cima dele(a).");
            }
        }
    }
}

