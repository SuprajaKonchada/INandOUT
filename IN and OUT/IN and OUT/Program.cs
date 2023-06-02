using System;
class Program
{
    public static void Add(in int id1, Emp obj1, out Emp obj2, out int id2)
    {
        Console.WriteLine("ID 1: " + id1);
        id2 = id1 + 250;
        Console.WriteLine("ID 2: " + id2);
        obj1 = new Emp();
        obj2 = new Emp();
        obj1.num = 30;
        obj2.num = 40;
    }
    public static void Main(string[] args)
    {
        int temp1 = 100;
        int temp2;
        Emp emp1 = new Emp();
        Emp emp2 = new Emp();
        emp1.num = 500;
        Add(temp1, emp1, out emp2, out temp2);
        Console.WriteLine("EMP 1: " + emp1.num);
        Console.WriteLine("EMP 2: " + emp2.num);
        Console.ReadKey();
    }
}
class Emp
{
    public int num;
}
