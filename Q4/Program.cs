using System;

public class Program {
    public static void Main() {
        int n; // จำนวนโหนด
        Console.Write("จำนวนโหนด: ");
        n = int.Parse(Console.ReadLine());

        // สร้างเมตริกซ์สำหรับเก็บเส้นเชื่อมโหนด
        int[,] matrix = new int[n, n];

        // รับคู่โหนดที่เชื่อมกัน
        int i, j, count = 0;
        Console.WriteLine("รับคู่โหนดที่เชื่อมกัน (จบโดยใส่เลขลบหรือเลขที่ไม่อยู่ในช่วง 0-" + (n - 1) + ")");
        while (true) {
            Console.Write("โหนดต้นทาง: ");
            i = int.Parse(Console.ReadLine());
            if (i < 0 || i >= n) break;

            Console.Write("โหนดปลายทาง: ");
            j = int.Parse(Console.ReadLine());
            if (j < 0 || j >= n) break;

            matrix[i, j] = 1;
            matrix[j, i] = 1;
        }

        // คำนวณจำนวนสัญลักษณ์ขั้นต่ำที่ต้องใช้
        bool[] used = new bool[n];
        int symbolCount = 0;
        for (i = 0; i < n; i++) {
            if (!used[i]) {
                used[i] = true;
                symbolCount++;
                for (j = i + 1; j < n; j++) {
                    if (!used[j] && !AreConnected(matrix, i, j)) {
                        used[j] = true;
                    }
                }
            }
        }

        // แสดงผลลัพธ์
        Console.WriteLine("จำนวนของสัญลักษณ์ขั้นต่ำที่ต้องใช้: " + symbolCount);
    }

    // ตรวจสอบว่าโหนด i และ j เชื่อมกันหรือไม่
    private static bool AreConnected(int[,] matrix, int i, int j) {
        return matrix[i, j] == 1;
    }
}
