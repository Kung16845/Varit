public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        printham(n);
    }
    static void printham(int n)
    {
        Console.WriteLine("Hamlet");
        if (n != 1)
        {
            printham(n - 1);
        } 
    }
}
