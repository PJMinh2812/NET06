// Tính tỷ lệ phần trăm
/*
Yêu cầu người dùng nhập vào một số và một tổng số, sau đó tính và in ra tỷ lệ phần trăm của số đó trong tổng số.
*/

//input:
// Enter a number: 25
// Enter the total number: 200
//process:
// percentage = (25 / 200) * 100 = 12.5
//output:
// Percentage: 12.5%
    

Console.WriteLine($"Enter a number: ");
double number = double.Parse(Console.ReadLine());   

Console.WriteLine($"Enter the total number: ");
double totalNumber = double.Parse(Console.ReadLine());  

double percentage = (number / totalNumber) * 100;
Console.WriteLine($"Percentage: {percentage}%");