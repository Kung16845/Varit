public class Program
{
    public static void Main (string[] args)
    {
        Console.Write("Please input a number of stations:");
        int stations = int.Parse(Console.ReadLine());
        if (stations == 1 )
        {
            Console.WriteLine("Cost (THB): 16 ");
        }
        else if (stations == 2 )
        {
            Console.WriteLine("Cost (THB): 23 ");
        }
        else if (stations == 3 )
        {
            Console.WriteLine("Cost (THB): 26 ");
        }
        else if (stations == 4 )
        {
            Console.WriteLine("Cost (THB): 30 ");
        }
        else if (stations == 5 )
        {
            Console.WriteLine("Cost (THB): 33 ");
        }
        else if (stations == 6 )
        {
            Console.WriteLine("Cost (THB): 37 ");
        }
        else if (stations == 7 )
        {
            Console.WriteLine("Cost (THB): 40 ");
        }
        else if (stations >= 8 && stations <= 15)
        {
            Console.WriteLine("Cost (THB): 44 ");
        }
        else if(stations > 15)
        {
            Console.WriteLine("Cost (THB): 59");
        }
        else 
        {
            Console.WriteLine("Please input agian");
        }
    }
}
