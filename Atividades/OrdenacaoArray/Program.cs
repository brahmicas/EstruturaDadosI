int[] vetor = new int[10];
for (int i = 0; i < vetor.Length; i++)
{
int b = i+1;
Console.WriteLine("Insira o "+ b + "° dígito do vetor:");
vetor[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(vetor);
Console.WriteLine(string.Join(",", vetor));
