using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Alicia = new Person("Alicia", 82);
            Person Javier = new Person("Javier", 52);
            Person Federico = new Person("Federico", 58);
            Person Julieta = new Person("Julieta", 22);
            Person Nicolas = new Person("Nicolas", 19);
            Person Guillermo = new Person("Guillermo", 22);
            Person MariaClara = new Person("María Clara", 19);
            
            
            
            Node<Person> n1 = new Node<Person>(Alicia);
            Node<Person> n2 = new Node<Person>(Javier);
            Node<Person> n3 = new Node<Person>(Federico);
            Node<Person> n4 = new Node<Person>(Julieta);
            Node<Person> n5 = new Node<Person>(Nicolas);
            Node<Person> n6 = new Node<Person>(Guillermo);
            Node<Person> n7 = new Node<Person>(MariaClara);
            


            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            
            AgeSumVisitor ageSumVisitor = new AgeSumVisitor();
            n1.Accept(ageSumVisitor);
            Console.WriteLine($"Suma de edades de la familia: {ageSumVisitor.TotalAge}. ");

            OldestChildVisitor oldestChildVisitor = new OldestChildVisitor();
            n1.Accept(oldestChildVisitor);
            Console.WriteLine($"The oldest child is {oldestChildVisitor.OldestChild.Content.Name}. ");

            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            n1.Accept(longestNameVisitor);
            Console.WriteLine($"The member with the longest name is {longestNameVisitor.LongestName}. ");

        }
    }
}
