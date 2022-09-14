public class Program
{
    public static void Main(string[] args)
    {   
        Console.Write("Input year : ");   
        int year = int.Parse(Console.ReadLine()); 
        Console.Write("Input month : ");  
        int month = int.Parse(Console.ReadLine());
        Console.Write("Input day : ");  
        int day = int.Parse(Console.ReadLine());    
          
        int numberday = day + conventmonthtoday(month) + (year*365);
        if ( 8 + conventmonthtoday(9) + (1868*365)  <  numberday && numberday < 29 + conventmonthtoday(7) + (1912*365) )
        {
            Console.WriteLine("Meji");         
        }
        else if (30 + conventmonthtoday(7) + (1912*365)  < numberday && numberday < 24 + conventmonthtoday(12) + (1926*365) )
        {
            Console.WriteLine("Taisho");
        }
        else if (25 + conventmonthtoday(12) + (1926*365)  < numberday && numberday < 7 + conventmonthtoday(1) + (1989*365) )
        {
            Console.WriteLine("Showa");
        }
        else if (8 + conventmonthtoday(1) + (1989*365)  < numberday && numberday < 30 + conventmonthtoday(4) + (2019*365) )
        {
            Console.WriteLine("Heisei");
        }
        else 
        {
            Console.WriteLine("Reiwa");
        }
        
    }
  
    public static int conventmonthtoday(int month)
    {
        int[] daymonth = new int[] {31,28,31,30,31,30,31,31,30,31,30,31};
        int sum = 0;
        for (int i = 0; i < month; i++)
        {
            sum += daymonth[i];
        }
        return sum;
    }
}
