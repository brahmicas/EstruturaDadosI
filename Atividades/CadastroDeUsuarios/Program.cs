using System.Collections;
using System.Linq.Expressions;

bool sair = false;
Hashtable hashtable = new();

Console.WriteLine("Bem-vindo ao programa de cadastro de usuários");

while (sair==false)
{
    string ? nome = "";
    string ? cpf = "";

    
    while (nome=="")
    {
        Console.WriteLine("Digite o nome:");
        nome = Console.ReadLine() ?? "";
        if(nome=="")
        {
            Console.WriteLine("\x1b[1;31mErro:\x1b[0m Nome não pode ser vazio.");
        }
    }

    while (cpf=="")
    {
        Console.WriteLine("Digite o CPF (somente números):");
        cpf = Console.ReadLine() ?? "";
        
        if (cpf.Length != 11)
        {   
            if(cpf == "")
            {
                Console.WriteLine("\x1b[1;31mErro:\x1b[0m CPF não pode ser vazio.");
            }
            else
            {
                Console.WriteLine("\x1b[1;31mErro:\x1b[0m CPF deve conter 11 caracteres, sendo apenas os números.");
            }
            cpf="";
        }
    }

    try
    {
        string nomehash = nome;
        string cpfhash = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        hashtable.Add(cpfhash, nomehash);
        nomehash = "";
        cpfhash = "";
    }
    catch(ArgumentException aex)
    {
        Console.Write("\x1b[1;31mErro:\x1b[0m chave duplicada inserida.");
        Console.WriteLine($" Detalhes: {aex.Message}");
    }

    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("               Usuários cadastrados                ");
    Console.WriteLine("---------------------------------------------------");
    foreach (DictionaryEntry de in hashtable)
    {
        Console.WriteLine(
            "Nome: {1} | CPF: {0}"
            , de.Key
            , de.Value
        );
        Console.WriteLine("---------------------------------------------------");
    }

    Console.WriteLine("Deseja cadastrar mais um usuário? (S/N)");
    string ? exit = Console.ReadLine() ?? "";
    exit = exit.ToLower();
    switch(exit) 
    {
    case "s":
        sair = false;
        break;

    case "n":
        sair=true;
        break;

    case "":
        sair=true;
        break;
    default:
        sair=true;
        break;
    }
}
