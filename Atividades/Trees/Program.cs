using Trees;

Tree<int> tree = new Tree<int>();
//inicializa o nó raiz com o valor 1000
tree.Root = new TreeNode<int>() {
     Data = 1000 
};
//troca o valor de data no nó Raiz
tree.Root.Data = 100;
//informa carga de nós filhos
tree.Root.Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { 
        Data = 50,
        Parent = tree.Root
    },
    new TreeNode<int>() { 
        Data = 5,
        Parent = tree.Root
    }
};
//adicionando nó em tempo de execução
TreeNode<int> filho3 = new TreeNode<int>();
filho3.Data = 0;
filho3.Parent = tree.Root;
tree.Root.Children.Add(filho3);

//adicionando netos  de root, ou seja, filhos do primeiro nivel de hereditariedade
tree.Root.Children[0].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { 
        Data = 55,
        Parent = tree.Root.Children[0]
    },
};
//adicionando netos de root no segundo filho
TreeNode<int> neto2 = new TreeNode<int>();
neto2.Data = 200;
neto2.Parent = tree.Root.Children[1];
tree.Root.Children[1].Children= new List<TreeNode<int>>();
tree.Root.Children[1].Children.Add(neto2);

int level = neto2.GetHeight();
string message = $"Está árvore contém {level} níveis.";
Console.WriteLine(message);