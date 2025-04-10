using System;

class Program
{
    // Hàm sắp xếp mảng số thực theo chiều tăng dần
    static void SortArrayAscending(double[] array)
    {
        Array.Sort(array); // Sử dụng phương thức Sort có sẵn để sắp xếp tăng dần
    }

    static void Main(string[] args)
    {
        // Nhập số lượng phần tử của mảng
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Khởi tạo mảng số thực
        double[] array = new double[n];

        // Nhập các phần tử của mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }

        // In mảng trước khi sắp xếp
        Console.WriteLine("Mang truoc khi sap xep:");
        Console.WriteLine(string.Join(" ", array));

        // Gọi hàm sắp xếp
        SortArrayAscending(array);

        // In mảng sau khi sắp xếp
        Console.WriteLine("Mang sau khi sap xep tang dan:");
        Console.WriteLine(string.Join(" ", array));
    }
}