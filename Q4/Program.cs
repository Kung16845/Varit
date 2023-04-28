using System;

class MainClass {
  public static void Main (string[] args) {
     // รับจำนวนโหนดในกราฟที่ไม่มีทิศทาง
    Console.Write("Enter number of nodes: ");
    List<(int, int)> pairs = new List<(int, int)>();
    int n = int.Parse(Console.ReadLine());
    int[] count = new int[n];
    for(int i = 0; i < n;i++)
    {
      count[i] = 0;
    }
    
    // รับคู่ลำดับโหนดที่มีเส้นเชื่อมต่อกัน
    Console.WriteLine("Enter pairs of nodes with edges (enter negative or out of range to stop):");

    while (true) {
      int src = int.Parse(Console.ReadLine());
      if (src < 0 || src >= n) break;

      int dest = int.Parse(Console.ReadLine());
      if (dest < 0 || dest >= n) break;

      pairs.Add((src, dest));
    }
    foreach (var pair in pairs)
    {
      Console.WriteLine("Source: " + pair.Item1 + ", Destination: " + pair.Item2);
      for(int j =0 ; j < n; j++)
      {
        if(pair.Item1 == j || pair.Item2 == j)
        {
          count[j]++;
        }
      }
    }
    for(int i = 0; i < n;i++)
    {
      Console.WriteLine("Number {0} Same are {1}  ",i,count[i]);     
    }
    Array.Sort(count);
    Array.Reverse(count);
    Console.WriteLine("Minimum Symbol are {0}",count[0]);
  }
}
