using System;
using System.Collections.Generic;
class Bai6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv:2415053122347.");
        Console.WriteLine("Bai 6: Kiem tra phan tu ton tai");
        List<string> list6 = new List<string>();
        Console.WriteLine("Nhap so luong phan tu:");
        int.TryParse(Console.ReadLine(), out var n6);
        if (n6 <= 0)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }
        for (int i = 0; i < n6; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}");
            String pt = Console.ReadLine();
            list6.Add(pt);
        }
        Console.WriteLine("Nhap phan tu can kiem tra:");
        String ten = Console.ReadLine();
        if (list6.Contains(ten))
        {
            Console.WriteLine($"Ton tai phan tu {ten}");
        }
        else
            Console.WriteLine($"Khong ton tai phan tu {ten}");
    }
}