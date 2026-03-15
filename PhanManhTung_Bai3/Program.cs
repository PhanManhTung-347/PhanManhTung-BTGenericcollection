using System;
using System.Collections.Generic;
class Bai3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv:2415053122347.");
        Console.WriteLine("Bai 3: Tim so lon nhat");
        List<int> list3 = new List<int>();
        Console.WriteLine("Nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n3);
        if (n3 <= 0)
        {
            Console.WriteLine("Danh sach trong, khong co so lon nhat.");
            return;
        }
        for (int i = 0; i < n3; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list3.Add(pt);
        }
        int max = list3[0];
        foreach (var pt3 in list3)
        {
            if (pt3 > max)
            {
                max = pt3;
            }
        }
        Console.WriteLine($"So lon nhat trong danh sach la:{max}");
    }
}