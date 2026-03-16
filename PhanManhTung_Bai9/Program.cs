using System;
using System.Collections.Generic;
class Bai9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv:2415053122347.");
        Console.WriteLine("Bai 9: Loai bo trung lap.");
        List<int> list9 = new List<int>();
        Console.WriteLine("Nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n9);
        if (n9 <= 0)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }
        for (int i = 0; i < n9; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            int.TryParse(Console.ReadLine(), out var pt);
            list9.Add(pt);
        }
        List<int> newlist = new List<int>();
        foreach (int pt in list9)
        {
            if (!newlist.Contains(pt))
            {
                newlist.Add(pt);
            }
        }
        Console.Write("Danh sach phan tu moi (khong chua phan tu trung):");
        foreach (int pt in newlist)
        {
            Console.Write($"{pt} ");
        }
    }
}