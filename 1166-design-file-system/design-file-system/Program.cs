// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Node
{
    public Node(int Value)
    {
        this.Value = Value;
        Children = new Dictionary<string, Node>();
    }

    public int Value { get; set; }
    public Dictionary<string, Node> Children { get; set; }
}

class FileSystem
{
    public Node Root;

     public FileSystem()
    {
        Root = new Node(-1);
    }

    
    private bool insert(string path, int value)
    {
        var paths = path.Split('/');
        Node node = Root;

        for (int i = 0; i < paths.Length; i++)
        {
            var currentPath = paths[i];

            if (!node.Children.ContainsKey(currentPath))
            {
                return false;
            }

            node = node.Children[currentPath];
        }

        if (node.Children.ContainsKey(paths[paths.Length - 1])) return false;

        node.Children.Add(path, new Node(value));

        return true;
    }

    public bool search(string path, int value)
    {
        return true;
    }

    public bool createPath(String path, int value)
    {
        return insert(path, value);
    }

    public int get(String path)
    {
        return 1;
    }
}