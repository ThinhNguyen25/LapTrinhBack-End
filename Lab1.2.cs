﻿//Bai1
//using System;

//class Program
//{
//    // Hàm tính tổng các số chẵn trong mảng
//    static int SumEvenNumbers(int[] array)
//    {
//        int sum = 0;
//        foreach (int number in array)
//        {
//            if (number % 2 == 0) // Kiểm tra số chẵn
//            {
//                sum += number;
//            }
//        }
//        return sum;
//    }

//    static void Main(string[] args)
//    {
//        // Nhập số lượng phần tử của mảng
//        Console.Write("Nhap so luong phan tu cua mang: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        // Khởi tạo mảng
//        int[] array = new int[n];

//        // Nhập các phần tử của mảng
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            array[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        // Tính tổng các số chẵn
//        int result = SumEvenNumbers(array);

//        // In kết quả
//        Console.WriteLine($"Tong cac so chan trong mang la: {result}");
//    }
//}


//Bai2
//using System;

//class Program
//{
//    // Hàm kiểm tra số nguy hiểm (tất cả các chữ số giống nhau)
//    static bool IsDangerousNumber(int number)
//    {
//        // Chuyển số thành chuỗi để dễ kiểm tra các chữ số
//        string numStr = Math.Abs(number).ToString();

//        // Nếu số chỉ có 1 chữ số, không coi là số nguy hiểm
//        if (numStr.Length == 1) return false;

//        // Lấy chữ số đầu tiên
//        char firstDigit = numStr[0];

//        // Kiểm tra các chữ số còn lại
//        for (int i = 1; i < numStr.Length; i++)
//        {
//            if (numStr[i] != firstDigit)
//            {
//                return false;
//            }
//        }
//        return true;
//    }

//    static void Main(string[] args)
//    {
//        // Nhập số lượng phần tử của mảng
//        Console.Write("Nhap so luong phan tu cua mang: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        // Khởi tạo mảng
//        int[] array = new int[n];

//        // Nhập các phần tử của mảng
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            array[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        // Kiểm tra và in ra các số nguy hiểm
//        Console.WriteLine("Cac so nguy hiem trong mang:");
//        bool found = false;
//        for (int i = 0; i < n; i++)
//        {
//            if (IsDangerousNumber(array[i]))
//            {
//                Console.WriteLine($"Chi so: {i}, Gia tri: {array[i]}");
//                found = true;
//            }
//        }

//        if (!found)
//        {
//            Console.WriteLine("Khong co so nguy hiem trong mang.");
//        }
//    }
//}


//Bai3
//using System;

//class Program
//{
//    // Hàm đếm số lượng số âm và số dương
//    static void CountPositiveNegative(int[] array, out int positiveCount, out int negativeCount)
//    {
//        positiveCount = 0;
//        negativeCount = 0;

//        foreach (int number in array)
//        {
//            if (number > 0)
//            {
//                positiveCount++;
//            }
//            else if (number < 0)
//            {
//                negativeCount++;
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        // Nhập số lượng phần tử của mảng
//        Console.Write("Nhap so luong phan tu cua mang: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        // Khởi tạo mảng
//        int[] array = new int[n];

//        // Nhập các phần tử của mảng
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            array[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        // Đếm số lượng số dương và số âm
//        int positiveCount, negativeCount;
//        CountPositiveNegative(array, out positiveCount, out negativeCount);

//        // In kết quả
//        Console.WriteLine($"So luong so duong trong mang: {positiveCount}");
//        Console.WriteLine($"So luong so am trong mang: {negativeCount}");
//    }
//}


//Bai4
//using System;

//class Program
//{
//    // Hàm tìm số lớn thứ hai trong mảng
//    static int FindSecondLargest(int[] array)
//    {
//        // Kiểm tra nếu mảng có ít hơn 2 phần tử
//        if (array.Length < 2)
//        {
//            throw new Exception("Mang phai co it nhat 2 phan tu.");
//        }

//        // Sắp xếp mảng theo thứ tự giảm dần
//        Array.Sort(array);
//        Array.Reverse(array);

//        // Tìm số lớn thứ hai (khác với số lớn nhất)
//        int largest = array[0];
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < largest)
//            {
//                return array[i];
//            }
//        }

//        // Nếu không tìm thấy số lớn thứ hai (tất cả phần tử giống nhau)
//        throw new Exception("Khong co so lon thu hai trong mang.");
//    }

//    static void Main(string[] args)
//    {
//        // Nhập số lượng phần tử của mảng
//        Console.Write("Nhap so luong phan tu cua mang: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        // Khởi tạo mảng
//        int[] array = new int[n];

//        // Nhập các phần tử của mảng
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            array[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        // Tìm số lớn thứ hai
//        try
//        {
//            int secondLargest = FindSecondLargest(array);
//            Console.WriteLine($"So lon thu hai trong mang la: {secondLargest}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}


//Bai5
//using System;

//class Program
//{
//    // Hàm hoán vị 2 số nguyên
//    static void SwapNumbers(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }

//    static void Main(string[] args)
//    {
//        // Nhập số thứ nhất
//        Console.Write("Nhap so nguyen a: ");
//        int a = Convert.ToInt32(Console.ReadLine());

//        // Nhập số thứ hai
//        Console.Write("Nhap so nguyen b: ");
//        int b = Convert.ToInt32(Console.ReadLine());

//        // In giá trị trước khi hoán vị
//        Console.WriteLine($"Truoc khi hoan vi: a = {a}, b = {b}");

//        // Gọi hàm hoán vị
//        SwapNumbers(ref a, ref b);

//        // In giá trị sau khi hoán vị
//        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
//    }
//}


//Bai6
//using System;

//class Program
//{
//    // Hàm sắp xếp mảng số thực theo chiều tăng dần
//    static void SortArrayAscending(double[] array)
//    {
//        Array.Sort(array); // Sử dụng phương thức Sort có sẵn để sắp xếp tăng dần
//    }

//    static void Main(string[] args)
//    {
//        // Nhập số lượng phần tử của mảng
//        Console.Write("Nhap so luong phan tu cua mang: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        // Khởi tạo mảng số thực
//        double[] array = new double[n];

//        // Nhập các phần tử của mảng
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            array[i] = Convert.ToDouble(Console.ReadLine());
//        }

//        // In mảng trước khi sắp xếp
//        Console.WriteLine("Mang truoc khi sap xep:");
//        Console.WriteLine(string.Join(" ", array));

//        // Gọi hàm sắp xếp
//        SortArrayAscending(array);

//        // In mảng sau khi sắp xếp
//        Console.WriteLine("Mang sau khi sap xep tang dan:");
//        Console.WriteLine(string.Join(" ", array));
//    }
//}