using System;

class Program
{
    // Hàm tìm số lớn thứ hai trong mảng
    static int FindSecondLargest(int[] array)
    {
        // Kiểm tra nếu mảng có ít hơn 2 phần tử
        if (array.Length < 2)
        {
            throw new Exception("Mang phai co it nhat 2 phan tu.");
        }

        // Sắp xếp mảng theo thứ tự giảm dần
        Array.Sort(array);
        Array.Reverse(array);

        // Tìm số lớn thứ hai (khác với số lớn nhất)
        int largest = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < largest)
            {
                return array[i];
            }
        }

        // Nếu không tìm thấy số lớn thứ hai (tất cả phần tử giống nhau)
        throw new Exception("Khong co so lon thu hai trong mang.");
    }

    static void Main(string[] args)
    {
        // Nhập số lượng phần tử của mảng
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Khởi tạo mảng
        int[] array = new int[n];

        // Nhập các phần tử của mảng
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Tìm số lớn thứ hai
        try
        {
            int secondLargest = FindSecondLargest(array);
            Console.WriteLine($"So lon thu hai trong mang la: {secondLargest}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}