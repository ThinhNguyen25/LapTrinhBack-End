using System;

class Program
{
    // Hàm hoán vị 2 số nguyên
    static void SwapNumbers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        // Nhập số thứ nhất
        Console.Write("Nhap so nguyen a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        // Nhập số thứ hai
        Console.Write("Nhap so nguyen b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        // In giá trị trước khi hoán vị
        Console.WriteLine($"Truoc khi hoan vi: a = {a}, b = {b}");

        // Gọi hàm hoán vị
        SwapNumbers(ref a, ref b);

        // In giá trị sau khi hoán vị
        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
    }
}