// Chuyển đổi đơn vị tiền tệ
/*
Yêu cầu người dùng nhập vào một số tiền bằng USD và tỷ giá chuyển đổi từ USD sang VND. 
Tính và in ra số tiền tương ứng bằng VND.
*/ 
Console.WriteLine($"Enter amount in USD: ");
double usd = double.Parse(Console.ReadLine());

Console.WriteLine($"Enter exchange rate (USD to VND): ");
double exchangeRate = double.Parse(Console.ReadLine());

double vnd = usd * exchangeRate;
Console.WriteLine($"Amount in VND: {vnd} VND");

//input:
// Enter amount in USD: 100 
// Enter exchange rate (USD to VND): 23000
//process:
// vnd = 100 * 23000 = 2300000  
//output:
// Amount in VND: 2300000 VND
