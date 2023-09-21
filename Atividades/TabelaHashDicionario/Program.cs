using System.Collections;
using System.Reflection;

//criar hashtable
Hashtable openWith = new Hashtable();

try
{
    openWith.Add("txt","notepad.exe");
    openWith.Add("bmp","paint.exe");
    openWith.Add("dib","paint.exe");
    openWith.Add("rtf","wordpad.exe");
}
catch(ArgumentException aex)
{
    Console.WriteLine("\x1b[1;31mErro:\x1b[0m chave duplicada inserida.");
    Console.WriteLine($"Detalhes: {aex.Message}");
}
catch
{
    Console.WriteLine("Errogenérico.");
}
//acessando o conteudo da tabela hash
Console.WriteLine("Na chave = \"rtf\" é {0}", openWith["rtf"] );

//alterando conteudo da tabela hash
openWith["rtf"] = "winword.exe";
Console.WriteLine("Na chave = \"rtf\" é {0}", openWith["rtf"] );

//testar se chave existe na hash
if(!openWith.ContainsKey("ht"))
{
    openWith.Add("ht","hypertrm.exe");
    Console.WriteLine("Chave ht adicionada");
}

//percorrendo hash com foreach
foreach (DictionaryEntry de in openWith)
{
    Console.WriteLine(
        "Key = {0} - Value = {1}"
        , de.Key
        , de.Value
    );
}

//obtendo apenas os valores do hash
ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach (string s in valueCol)
{
    Console.WriteLine(
        "value = {0}"
        , s
    );
}

//obtendo apenas as chaves do hash
ICollection keyCol = openWith.Keys;
Console.WriteLine();
foreach (string s in keyCol)
{
    Console.WriteLine(
        "key = {0}"
        , s
    );
}

//remover registro do hash
Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");
if (!openWith.ContainsKey("doc"))
{
    Console.WriteLine(
        "Chave \"doc\" foi removida."
    );
}