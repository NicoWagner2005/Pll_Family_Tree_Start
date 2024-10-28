namespace Library;

public class LongestNameVisitor : IVisitor<Person>
{
    public string LongestName { get; private set; } = "";
        
    public void Visit(Node<Person> node)
    {
        if (node.Content.Name.Length > LongestName.Length)
        {
            LongestName = node.Content.Name;
        }
    }
}