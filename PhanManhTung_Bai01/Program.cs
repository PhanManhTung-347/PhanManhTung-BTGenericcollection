using System;
class Bai1
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv:2415053122347.");
        Console.WriteLine("Bai 1: Tao danh sach so nguyen");
        List<int> list1 = new List<int>();
        list1.Add(1);
        list1.Add(2);
        list1.Add(3);
        list1.Add(4);
        list1.Add(5);
        Console.WriteLine("Danh sach ca phan tu:");
        foreach (var pt in list1)
        {
            Console.WriteLine(pt);
        }
    }
}