using System;

class Program
{
    static void Main(string[] args)
    {
        Set<int> s = new Set<int>();
        s.Add(20000);
        s.Add(30000);
        s.Add(30000);
        s.Add(10000);
        s.Remove(20000);

        Console.WriteLine(s.Search(20000));
        Console.WriteLine(s.Search(30000));
        Console.WriteLine(s);
    }
}