        // Nhập chiều dài
        Console.Write("Nhap chieu dai cua hinh chu nhat: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Nhập chiều rộng
        Console.Write("Nhap chieu rong cua hinh chu nhat: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Tính diện tích
        double area = length * width;

        // In kết quả
        Console.WriteLine($"Dien tich hinh chu nhat la: {area}");
 