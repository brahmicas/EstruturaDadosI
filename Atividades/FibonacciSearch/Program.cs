using System;

class BuscaFibonacci
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static int BuscaFibonacciFunc(int[] arr, int x)
    {
        int tamanho = arr.Length;
        int fibM_menos_2 = 0;
        int fibM_menos_1 = 1;
        int fibM = fibM_menos_1 + fibM_menos_2;

        while (fibM < tamanho)
        {
            fibM_menos_2 = fibM_menos_1;
            fibM_menos_1 = fibM;
            fibM = fibM_menos_1 + fibM_menos_2;
        }

        int offset = -1;

        while (fibM > 1)
        {
            int i = Math.Min(offset + fibM_menos_2, tamanho - 1);

            if (arr[i] < x)
            {
                fibM = fibM_menos_1;
                fibM_menos_1 = fibM_menos_2;
                fibM_menos_2 = fibM - fibM_menos_1;
                offset = i;
            }
            else if (arr[i] > x)
            {
                fibM = fibM_menos_2;
                fibM_menos_1 = fibM_menos_1 - fibM_menos_2;
                fibM_menos_2 = fibM - fibM_menos_1;
            }
            else
            {
                return i;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] arr = { 10, 22, 35, 40, 45, 50, 80, 82, 85, 90, 100 };
        int x = 24;
        int resultado = BuscaFibonacciFunc(arr, x);

        if (resultado == -1)
        {
            Console.WriteLine($"Valor {x} não encontrado no array.");
        }
        else
        {
            Console.WriteLine($"Valor {x} encontrado na posição {resultado}.");
        }
    }
}