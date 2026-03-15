using System;
using System.Collections.Generic;
class Bai8
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv:2415053122347.");
        Console.WriteLine("Bai 8: Dao nguoc phan tu");
        List<int> list8 = new List<int>();
        Console.WriteLine("Nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n8);
        if (n8 <= 0)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }
        for (int i = 0; i < n8; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list8.Add(pt);
        }
        Console.Write("Danh sach phan tu truoc dao nguoc:");
        foreach (var pt in list8)
        {
            Console.Write($"{pt} ");
        }
        Console.Write("\n");
        list8.Reverse();
        Console.Write("Danh sach phan tu sau dao nguoc:");
        foreach (var pt in list8)
        {
            Console.Write($"{pt} ");
        }
    }
}