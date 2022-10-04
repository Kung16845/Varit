public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input number : ");
        int n = int.Parse(Console.ReadLine());
        var sorts = new List<int> {} ;
        var allnumber = new int[n];
        int num;
        inputnumber(allnumber,n,0);
        for (int i = 0 ; i < allnumber.Length - 1 ;i++)
        {
            if (allnumber[i] > allnumber[i+1])
            {
                num = allnumber[i];
                allnumber[i] = allnumber[i+1];
                allnumber[i+1] = num; 
                i = -1;  
            }                                                                                                      
        }       
        foreach (int number in allnumber)
        {
            Console.WriteLine("{0}",number);
        }
        
    }
    static void inputnumber(int[] all,int n, int a)
    {
        all[a] = int.Parse(Console.ReadLine());
        
        if(n != 1)
        {
            inputnumber( all,n-1,a+1);
        }
        
    }
    
}