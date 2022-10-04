public class Program 
{
    public static void Main(string[] args)
    {
        var name = new List<string> {};
        int n = int.Parse(Console.ReadLine());
        inputname(n,name);
        name.Reverse();
        foreach(var a in name)
        {
            Console.WriteLine(a);
        }
        
    }   
    static void inputname(int n, List<string> name) 
    {      
        for (int i = 0 ; i < n ; i++)
        {
           string names = Console.ReadLine();
           name.Add(names);
        }
    }
}