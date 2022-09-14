public class Program
{
    public static void Main (string[] args)
    {
        Console.Write("Number of products : ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Percentage of product : ");
        int discount = int.Parse(Console.ReadLine());
        checkLapeeShopzada(number,discount);
        
    }
    static void checkLapeeShopzada(int number,int discount)
    {
        int price = 100;
        if (number * 100 < price*(100-discount)/100 * (number +1))
        {
            Console.WriteLine("Lapee");
        }
        else if (number * 100 > price*(100-discount)/100 * (number +1))
        {
            Console.WriteLine("Shopzada");
        }
        else
        {
            Console.WriteLine("E-mazon");
        }
    }
}