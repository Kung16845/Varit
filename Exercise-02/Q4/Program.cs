public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input number of level : ");
        int n = int.Parse(Console.ReadLine());
        n = n-1;
        for (int i = 1 ; i <= n ;i++)
        {
             for (int j = n; j >= i; j--) 
             {
                Console.Write(" ");
             }
             for (int j = 1; j <= i * 2 - 1 ; j++) 
             {              
                if (j == 1 || j == i * 2 -1)
                {
                    Console.Write("#");      
                }            
                else 
                {
                    Console.Write(" ");
                }                 
             }             
             Console.WriteLine();   
        }
        for (int i = 0 ; i <= n * 2  ;i++)
        {
            Console.Write("#");
        }
    }    
}
