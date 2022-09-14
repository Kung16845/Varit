public class Program
{
    public static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        if (width < 0)
        {
            Console.WriteLine("Please input a positive integer.");
        } 
        else if (width % 1 != 0) 
        {
            Console.WriteLine("“Please input an integer.”");
        }
        else if (width % 2 != 0) 
        {
            Console.WriteLine("“Please input an even positive integer.”");
        }
        else 
        {
            Console.WriteLine("{0}, {1}",width/2,width/2 +1 );
        }    
    }
}
