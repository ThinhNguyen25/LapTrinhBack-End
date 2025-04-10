// Nhập năm
Console.Write("Nhap mot nam: ");
int year = Convert.ToInt32(Console.ReadLine());

// Kiểm tra năm nhuận
bool isLeapYear = false;

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            isLeapYear = true;
        }
    }
    else
    {
        isLeapYear = true;
    }
}

// In kết quả
if (isLeapYear)
{
    Console.WriteLine($"{year} la nam nhuan.");
}
else
{
    Console.WriteLine($"{year} khong phai la nam nhuan.");
}