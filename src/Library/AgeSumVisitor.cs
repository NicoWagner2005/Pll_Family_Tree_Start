namespace Library;

public class AgeSumVisitor: IVisitor<Person>
{
    public int TotalAge { get; private set; }

    public void Visit(Node<Person> node)
    {
        TotalAge += node.Content.Age;
    }
}