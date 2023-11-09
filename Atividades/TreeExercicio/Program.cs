public class TreeNode<T>
{
    public T Data { get; set; }
    public TreeNode<T> Parent { get; set; }
    public List<TreeNode<T>> Children { get; set; }
    public int GetHeight()
    {
        int height = 1;
        TreeNode<T> current = this;
        while (current.Parent != null)
        {
            height++;
            current = current.Parent;
        }
        return height;
    }
}
public class Tree<T>
{
    public TreeNode<T> Root { get; set; }
}
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public Person(){}
    public Person(int id, string name, string role)
    {
        Id = id;
        Name = name;
        Role = role;
    }
}
public class Program
{
    static void Main()
    {
        Tree<Person> company = new Tree<Person>();
        company.Root = new TreeNode<Person>()
        {
            Data = new Person(100, "Marcin Jamro", "CEO"),
            Parent = null
        };

        company.Root.Children = new List<TreeNode<Person>>()
        {
            new TreeNode<Person>()
            {
                Data = new Person(1, "John Smith", "Head of Development"),
                Parent = company.Root
            },
            new TreeNode<Person>()
            {
                Data = new Person(50, "Maty Fox", "Head of Research"),
                Parent = company.Root
            },
            new TreeNode<Person>()
            {
                Data = new Person(150, "Lily Smith", "Head of Sales"),
                Parent = company.Root
            }
        };
        company.Root.Children[2].Children = new List<TreeNode<Person>>()
        {
            new TreeNode<Person>()
            {
                Data = new Person(30, "Anthony Black", "Sales Specialist"),
                Parent = company.Root.Children[2]
            }
        };
        Console.WriteLine($"A ID do líder do setor de vendas é {company.Root.Children[2].Data.Id}.");
        Console.WriteLine($"O nome do especialista do setor de vendas é {company.Root.Children[2].Children[0].Data.Name}.");
    }
}