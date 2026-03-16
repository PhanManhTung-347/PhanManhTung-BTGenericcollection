using System;
using System.Collections.Generic;

class Bai16
{
    static void Main()
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv: 2415053122347.");
        Console.WriteLine("Bai 16: Dem so lan xuat hien cua ky tu trong chuoi");
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        Dictionary<char, int> dem = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (dem.ContainsKey(c))
                dem[c] = dem[c] + 1;
            else
                dem[c] = 1;
        }
        Console.WriteLine("\nKet qua:");
        foreach (var item in dem)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}