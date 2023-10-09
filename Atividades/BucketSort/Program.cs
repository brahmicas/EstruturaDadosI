using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] array = new int[10];
        Random random=new Random();
        for (int i =0; i < array.Length; i++)
        { 
            array[i] = random.Next(-50, 50); 
        }
        Console.WriteLine("vetores desorganizado");
        for (int i = 0; i < array.Length; i++)
        { 
            Console.Write(array[i] + ", "); 
        } 
        Console.WriteLine();
        Console.WriteLine("vetores organizado");

        int[] sortedArray = BucketSort(array);
        Console.WriteLine(string.Join(", ", sortedArray));
    }
    
    public static int[] BucketSort(int[] array)
    {
        // Encontre o valor mínimo e máximo do array
        int min = array[0];
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }
        
        // Calcule o intervalo de cada balde
        int bucketRange = (max - min + 1) / array.Length + 1;
        
        // Crie uma lista de listas vazias para representar os baldes
        List<List<int>> buckets = new List<List<int>>();
        for (int i = 0; i < array.Length; i++)
        {
            buckets.Add(new List<int>());
        }
        
        // Para cada elemento do array, calcule o índice do balde correspondente e adicione o elemento nesse balde
        for (int i = 0; i < array.Length; i++)
        {
            int bucketIndex = (array[i] - min) / bucketRange;
            buckets[bucketIndex].Add(array[i]);
        }
        
        // Para cada balde, ordene os seus elementos usando insertion sort
        for (int i = 0; i < buckets.Count; i++)
        {
            InsertionSort(buckets[i]);
        }
        
        // Concatene todos os baldes ordenados em um novo array
        int[] sortedArray = new int[array.Length];
        int index = 0;
        for (int i = 0; i < buckets.Count; i++)
        {
            for (int j = 0; j < buckets[i].Count; j++)
            {
                sortedArray[index++] = buckets[i][j];
            }
        }
        
        return sortedArray;
    }
    
    public static void InsertionSort(List<int> list)
    {
        for (int i = 1; i < list.Count; i++)
        {
            int key = list[i];
            int j = i - 1;
            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = key;
        }
    }
}