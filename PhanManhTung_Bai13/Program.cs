using System;
using System.Collections.Generic;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Student(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
}
class Bai13
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ho va ten: Phan Manh Tung || Msv: 2415053122347.");
        Console.WriteLine("Bai 13: Dem so sinh vien.");
        List<Student> students = new List<Student>();
        students.Add(new Student(1, "Van A"));
        students.Add(new Student(2, "Van B"));
        students.Add(new Student(3, "Van C"));
        students.Add(new Student(4, "Van D"));
        students.Add(new Student(5, "Van E"));
        Console.WriteLine($"Danh sach sinh vien:");
        foreach (Student student in students)
        {
            Console.WriteLine($"ID:{student.Id} || Name:{student.Name}");
        }
        Console.WriteLine($"Danh sach co {students.Count} sinh vien");
    }
}