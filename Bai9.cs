// Nhập số nguyên dương
Console.Write("Nhap mot so nguyen duong n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Kiểm tra số nhập vào có phải là số nguyên dương
if (n < 0)
{
    Console.WriteLine("Vui long nhap mot so nguyen duong!");
    return;
}

// Tính giai thừa
long factorial = 1;
for (int i = 1; i <= n; i++)
{
    factorial *= i;
}

// In kết quả
Console.WriteLine($"Giai thua cua {n} la: {factorial}");