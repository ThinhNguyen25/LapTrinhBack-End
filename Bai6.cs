// Nhập số
Console.Write("Nhap mot so: ");
double number = Convert.ToDouble(Console.ReadLine());

// Kiểm tra số dương, âm hay bằng 0
if (number > 0)
{
    Console.WriteLine($"{number} la so duong.");
}
else if (number < 0)
{
    Console.WriteLine($"{number} la so am.");
}
else
{
    Console.WriteLine($"{number} la so khong.");
}