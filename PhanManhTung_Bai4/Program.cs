using System;
using System.Collections.Generic;
class Bai4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv:2415053122347.");
        Console.WriteLine("Bai 4: Dem so chan");
        List<int> list4 = new List<int>();
        Console.WriteLine("Nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n4);
        if (n4 <= 0)
        {
            Console.WriteLine("Danh sach trong!");
            return;
        }
        for (int i = 0; i < n4; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list4.Add(pt);
        }
        int count = 0;
        foreach (var pt4 in list4)
        {
            if (pt4 % 2 == 0)
            {
                count = count + 1;
            }
        }
        Console.WriteLine($"So luog phan tu chan la:{count}");

    }
}