//  Tính số dư sau khi rút tiền từ tài khoản
/*
Yêu cầu người dùng nhập vào số dư tài khoản hiện tại và số tiền muốn rút. 
Tính và in ra số dư còn lại sau khi rút tiền (lưu ý không kiểm tra số dư âm ở bài này).
*/

//input:
// Enter current account balance: 1000
// Enter amount to withdraw: 200
//process:
// remaining = 1000 - 200 = 800
//output:   
// Remaining balance: 800



Console.WriteLine($"Enter current account balance: ");
double balance = double.Parse(Console.ReadLine());

Console.WriteLine($"Enter amount to withdraw: ");
double withdraw = double.Parse(Console.ReadLine());         

double remaining = balance - withdraw;

Console.WriteLine($"Remaining balance: {remaining}");