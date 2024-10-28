namespace Library;

public class OldestChildVisitor: IVisitor<Person>
{
    public int OlderAge { get; set; } = 0;
    public Node<Person> OldestChild { get; private set; }
    
    public void Visit(Node<Person> node)
    {
        foreach (Node<Person> child in node.Children)
        {
            if (child.Content.Age > OlderAge)
            {
                OlderAge = child.Content.Age;
                OldestChild = child;
            }
        }
            
    }
}