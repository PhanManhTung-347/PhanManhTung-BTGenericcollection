using System;
using System.Collections.Generic;
class Bai5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv:2415053122347.");
        Console.WriteLine("Bai 5: Xoa phan tu khoi list");
        List<string> list5 = new List<string>();
        Console.WriteLine("Nhap so luong sinh vien:");
        int.TryParse(Console.ReadLine(), out var n5);
        if (n5 <= 0)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }
        for (int i = 0; i < n5; i++)
        {
            Console.WriteLine($"Nhap sinh vien thu {i + 1}");
            String pt = Console.ReadLine();
            list5.Add(pt);
        }
        Console.WriteLine("Nhap ten sinh vien can xoa:");
        string ten = Console.ReadLine();
        if (list5.Contains(ten))
        {
            while (list5.Contains(ten))
            {
                list5.Remove(ten);
            }
            Console.WriteLine($"Da xoa tat ca sinh vien co ten {ten}");
        }
        else
            Console.WriteLine("Khong tim thay ten sinh vien de xoa");
        Console.WriteLine("Danh sach sinh vien la:");
        foreach (var pt5 in list5)
        {
            Console.WriteLine(pt5);
        }
    }
}