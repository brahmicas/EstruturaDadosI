string [,] matriz = new string [3,3];
bool vitoria=false;

Console.WriteLine("Bem-vindo ao jogo da velha!");
Console.WriteLine("Na vez de cada jogador, será pedido a linha e a coluna onde deseja jogar.");

while (vitoria==false)
{
    //vez de X
    bool x = false;
    while (x == false)
    {
        Console.WriteLine("Vez de X:");
        Console.WriteLine("Numero da linha:");
        int linhax = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Numero da coluna:");
        int colunax = Convert.ToInt32(Console.ReadLine()); 
        if (matriz[linhax, colunax] == null)
        {
            matriz[linhax, colunax]="X";
            x=true;
        }  
        else
        {
            Console.WriteLine("Posição já ocupada.");
        }    

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(
                    $"[{matriz[i,j]}]"
                );
            }
            Console.WriteLine("");
        } 
    }

    //vez de O
    bool o = false;
    while (o==false)
    {
        Console.WriteLine("Vez de O:");
        Console.WriteLine("Numero da linha:");
        int linhao = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Numero da coluna:");
        int colunao = Convert.ToInt32(Console.ReadLine()); 
        if (matriz[linhao, colunao] == null)
        {
            matriz[linhao, colunao]="O";
            o = true;
        }  
        else
        {
            Console.WriteLine("Posição já ocupada.");
        }
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(
                    $"[{matriz[i,j]}]"
                );
            }
            Console.WriteLine("");
        } 
    }
};