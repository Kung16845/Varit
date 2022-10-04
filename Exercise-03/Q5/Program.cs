public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Number of array01  : ");
        int n = int.Parse(Console.ReadLine());
        int[] array01 = new int[n]; 
        inputnumber(array01,n,0);
        Console.Write("Number of array02  : ");
        int z = int.Parse(Console.ReadLine());
        int[] array02 = new int[z]; 
        int check = 0;
        inputnumber(array02,z,0);
        Array.Sort(array01);
        Array.Sort(array02);
        List<int> allnumber = new List<int> {};
        
        for (int i = 0; i < array01.Length; i++)
        {
            for(int j = 0 ; j < array02.Length;j++)
            {
                if (array01[i] == array02[j] && array01[i] != check)
                {               
                    allnumber.Add(array01[i]);                 
                } 
                else if(array01[i] != array02[j] && array01[i] != check)
                {
                    allnumber.Add(array01[i]);                  
                }                        
                check = array01[i];      
            }          
        }
        for(int j = 0;j < array02.Length;j++)
        {
            for(int i = 0 ; i < array01.Length ;i++)
            {
                if(array02[j] != array01[i] && array02[j] != check)
                {
                    allnumber.Add(array02[j]);
                }
                check = array02[j]; 
            }
        }      
        allnumber.Sort();  
        foreach (int a in allnumber)
        {
            Console.Write("{0} ",a);
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
