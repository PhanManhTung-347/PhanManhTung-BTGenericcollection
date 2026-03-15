using System;
using System.Collections.Generic;
class Bai7
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv:2415053122347.");
        Console.WriteLine("Bai 7: Sap xep danh sach");
        List<int> list7 = new List<int>();
        Console.WriteLine("Nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n7);
        if (n7 <= 0)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }
        for (int i = 0; i < n7; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list7.Add(pt);
        }
        Console.Write("Danh sach phan tu truoc sap xep:");
        foreach( var pt in list7)
        {
            Console.Write($"{pt} ");
        }
        Console.Write("\n");
        list7.Sort();
        Console.Write("Danh sach phan tu sau sap xep (tang dan):");
        foreach (var pt in list7)
        {
            Console.Write($"{pt} ");
        }
    }
}