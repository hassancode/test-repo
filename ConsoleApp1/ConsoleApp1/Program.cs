namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        var s = new Stack();
        s.Push("1");
        s.Push("2");
        s.Push("3");
        s.Print();
        
        var popped = s.Pop();
        System.Console.WriteLine("popped: " + popped);
        s.Print();
    }
}
