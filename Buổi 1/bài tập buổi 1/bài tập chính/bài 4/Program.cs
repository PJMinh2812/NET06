//  Tính tổng số tiền sau khi cộng thêm thuế VAT
/*
Yêu cầu người dùng nhập vào số tiền gốc và tỷ lệ thuế VAT (ví dụ: 10%). 
Tính và in ra tổng số tiền sau khi đã cộng thêm thuế
*/
Console.WriteLine($"Enter the amount: ");
double amount = double.Parse(Console.ReadLine());

Console.WriteLine($"Enter VAT percentage: ");
double vat = double.Parse(Console.ReadLine());

double vatAmount = amount * (vat / 100);
double total = amount + vatAmount;
Console.WriteLine($"Total amount after VAT: {total}");

//input:
// Enter the amount: 1000
// Enter VAT percentage: 10     
//process:
// vatAmount = 1000 * (10 / 100) = 100
// total = 1000 + 100 = 1100
//output:
// Total amount after VAT: 1100
