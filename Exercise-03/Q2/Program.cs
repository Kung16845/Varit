public class Program
{
    public static void Main(string[] args)
    {
        int a = 1;
        Console.Write("Number of cabel : ");
        int n = int.Parse(Console.ReadLine());  
        Console.Write("Number of internet cabel : ");
        int m = int.Parse(Console.ReadLine());  
        int[,] tablecable = new int[m,n];  
        string[,] openclose = new string[m,n];      
        string[] onoff = new string[n]; 
        int[,] allinternet = new int[m,n];
        int[] internet = new int[m];
        inputOnOff(n,onoff,0);
        inputinternet(m,internet,0);
        Console.Write("Number of Computer : ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < m;i++)
        {
            for (int j = 0; j < n ; j++)
            {
                tablecable[i,j] = a;
                a++;  
            }
            Console.WriteLine();
        }    
        for (int i = 0; i < m;i++)
        {
            for (int j = 0; j < n ; j++)
            {
                openclose[i,j] = onoff[j];             
            }
            Console.WriteLine();
        }         
        for (int i = 0; i < m;i++)
        {
            for (int j = 0; j < n ; j++)
            {
                allinternet[i,j] = internet[i];
            }
            Console.WriteLine();
        }
         for (int i = 0; i < m;i++)
        {
            for (int j = 0; j < n ; j++)
            {
                if (number == tablecable[i,j])
                {
                    if (openclose[i,j] == "True")
                        Console.WriteLine("{0} Mbps",allinternet[i,j]);
                    else
                        Console.WriteLine("Offline");
                }
            }
        }
    }
    public static void inputOnOff(int n,string[] name,int num)
    {
        Console.Write("Input True for On or False for Off : ");
        name[num] = Console.ReadLine();
        if(n != 1)
        {
            inputOnOff(n-1,name,num+1);
        }
    } 
     public static void inputinternet(int m,int[] net,int num)
     {
        Console.Write("Input speed internet : ");
        net[num] = int.Parse(Console.ReadLine());
        if(m != 1)
        {
            inputinternet(m-1,net,num+1);
        }
     }
}
