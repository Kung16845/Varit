public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input number of level : ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine(numbercure(n));
    }
    static double sum = 0;
    static double numbercure(int n)
    {      
        double number;
        if (n != 0)
        {
            number = Math.Pow(n * 2 - 1 ,2);
            sum = sum + number;
            numbercure(n-1);
        }       
            return sum;
        
    }
}