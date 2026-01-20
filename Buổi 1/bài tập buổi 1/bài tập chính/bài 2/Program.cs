//Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá

/*
Yêu cầu người dùng nhập vào giá trị của một đơn hàng và phần trăm giảm giá. 
Tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dụng giảm giá.
*/

//input:
// Enter total order value: 500
// Enter discount percentage: 10
//process:
// discountMoney = 500 * (10 / 100)  = 50
// totalMoney = 500 - 50 = 450
//output:
// Discount amount: 50
// Total amount after discount: 450

Console.Write($"Enter total order value: ");
double money = double.Parse(Console.ReadLine());    

Console.Write($"Enter discount percentage: ");
double discount = double.Parse(Console.ReadLine());

double discountMoney = money * (discount / 100)  ;
double totalMoney = money - discountMoney;

Console.WriteLine($"Discount amount: {discountMoney}");
Console.WriteLine($"Total amount after discount: {totalMoney}");

