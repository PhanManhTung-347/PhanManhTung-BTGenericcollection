using System;
using System.Collections.Generic;
class Bai10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv:2415053122347.");
        Console.WriteLine("Bai 10: Tim phan tu nho nhat");
        List<int> list10 = new List<int>();
        Console.WriteLine("Nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n10);
        if (n10 <= 0)
        {
            Console.WriteLine("Danh sach trong, khong co so lon nhat.");
            return;
        }
        for (int i = 0; i < n10; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list10.Add(pt);
        }
        int min = list10[0];
        foreach (var pt in list10)
        {
            if (pt < min)
            {
                min = pt;
            }
        }
        Console.WriteLine($"So nho nhat trong danh sach la:{min}");
    }
}