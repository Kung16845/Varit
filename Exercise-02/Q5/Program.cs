public class Program
{
    public static void Main(string[] args)
    {
        string  things;
        int numberyears;
        do 
        {
            Console.Write("Inpur position : ");
            things = Console.ReadLine();
            Console.Write("Inpur year : ");
            numberyears = int.Parse(Console.ReadLine());    
            checkyear(numberyears,things);   
 
        }while (numberyears < 2565);  
       Console.WriteLine(namelow);
       Console.WriteLine(lowyear);
       Console.WriteLine(namehigh);
       Console.WriteLine(highyear);
       Console.WriteLine(highyear - lowyear); 
    }
    static string namehigh,namelow;
    static int highyear = int.MinValue,lowyear = int.MaxValue;
    static void checkyear(int year, string posotion)
    {
        if (year > highyear)
        {
            highyear = year;
            namehigh = posotion;
        }
        if (year < lowyear)
        {
            lowyear = year;
            namelow = posotion;
        }
    }
}
