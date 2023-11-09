class Program
{
    static readonly string[,] matriz = new string[3, 3];
    static bool vitoria = false;

    static void Main(string[] args)
    {
        string novamente = "s";
        while (novamente == "s")
        {
            Console.WriteLine("Bem-vindo ao jogo da velha!");
            Console.WriteLine("Na vez de cada jogador, será pedido a linha e a coluna onde deseja jogar.");

            while (vitoria == false)
            {
                FazerJogada("X");

                if (vitoria==false)
                    FazerJogada("O");
            }
            Console.WriteLine("Jogo finalizado, jogar novamente? (s/n)");
            novamente = Console.ReadLine() ?? "n";
            novamente = novamente.ToLower();
            if (novamente == "s")
            {
                vitoria = false;
                Array.Clear(matriz);
            }
        }
    }

    static void FazerJogada(string jogador)
    {
        bool jogadaValida = false;

        while (jogadaValida==false)
        {
            Console.WriteLine($"Vez de {jogador}:");
            Console.WriteLine("Número da linha:");
            int linha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número da coluna:");
            int coluna = Convert.ToInt32(Console.ReadLine());

            if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && matriz[linha, coluna] == null)
            {
                matriz[linha, coluna] = jogador;
                jogadaValida = true;
                ImprimirTabuleiro();
                vitoria = VerificarVitoria(jogador, linha, coluna);
            }
            else
            {
                Console.WriteLine("Posição ocupada.");
            }
        }
    }

    static void ImprimirTabuleiro()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"[{matriz[i, j] ?? " "}]");
            }
            Console.WriteLine();
        }
    }

    static bool VerificarVitoria(string jogador, int linha, int coluna)
    {
        if (matriz[linha, 0] == jogador && matriz[linha, 1] == jogador && matriz[linha, 2] == jogador)
            return true;

        if (matriz[0, coluna] == jogador && matriz[1, coluna] == jogador && matriz[2, coluna] == jogador)
            return true;

        if (linha == coluna)
        {
            if (matriz[0, 0] == jogador && matriz[1, 1] == jogador && matriz[2, 2] == jogador)
                return true;
        }

        if (linha + coluna == 2)
        {
            if (matriz[0, 2] == jogador && matriz[1, 1] == jogador && matriz[2, 0] == jogador)
                return true;
        }

        return false;
    }
}
