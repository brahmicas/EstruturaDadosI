using System;
using System.Collections.Generic;

class Program
{
    public static void BucketSort(int[] array)
    {
        if (array == null || array.Length <= 1)
            return;

        int maxValue = array[0];
        int minValue = array[0];

        // Encontre o valor máximo e mínimo no vetor
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxValue)
                maxValue = array[i];
            if (array[i] < minValue)
                minValue = array[i];
        }

        // Crie um vetor temporário para contar as ocorrências dos valores
        int[] bucket = new int[maxValue - minValue + 1];

        // Conte as ocorrências dos valores no vetor original
        for (int i = 0; i < array.Length; i++)
        {
            bucket[array[i] - minValue]++;
        }

        // Coloque os valores ordenados de volta no vetor original
        int index = 0;
        for (int i = 0; i < bucket.Length; i++)
        {
            while (bucket[i] > 0)
            {
                array[index] = i + minValue;
                index++;
                bucket[i]--;
            }
        }
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine("Imprimendo os vetores ");
        foreach (var item in array)
        {
            Console.Write(item + ", "); // Correção de "iten" para "item"
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = new int[12]; // Definindo o tamanho do vetor como 12

        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-50, 50);
        }

        Console.WriteLine("Arrays desordenados");
        PrintArray(array);
        Console.WriteLine("====================");
        BucketSort(array);
        Console.WriteLine("Arrays ordenados");
        PrintArray(array);
        Console.WriteLine("====================");
    }
}