public class Program
{
    public static void Main (string[] args)
    {
        Console.Write("Input Level : ");   
        int Level = int.Parse(Console.ReadLine());     
        
        if (Level - 1 >= 0  )
        {      
            Console.WriteLine("yellow");
            Level = Level - 1;
            if (Level - 2 >= 0 )
            {
                Console.WriteLine("orange");   
                Level = Level - 2;
                if(Level - 4 >= 0)   
                {
                    Console.WriteLine("red");  
                }       
            }
        }
    }
}
