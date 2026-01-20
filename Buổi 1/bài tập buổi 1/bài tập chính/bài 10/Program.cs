// Tính lượng calo tiêu thụ
/*
Yêu cầu người dùng nhập vào số phút đã tập thể dục và loại hình tập thể dục
(chọn từ các giá trị đã định trước như chạy, đạp xe, bơi lội). 
Tính và in ra lượng calo tiêu thụ dựa trên số phút và loại hình tập thể dục
(sử dụng hệ số calo tiêu thụ giả định cho mỗi loại hình).
*/


//input:
 // Choose exercise type (1-running, 2-cycling, 3-swimming): 1
 // Enter duration (minutes): 30
 //process:
 // caloriesPerMinute = 60; // for running
 //caloriesPerMinute = 40;  // for cycling
 //caloriesPerMinute = 55; // for swimming
 // totalCalories = caloriesPerMinute * duration;
 //output:
 // Total calories burned: 1800

Console.WriteLine($"Choose exercise type (1-running, 2-cycling, 3-swimming): ");
int type = int.Parse(Console.ReadLine());  

Console.WriteLine($"Enter duration (minutes): ");
double duration = double.Parse(Console.ReadLine());

double caloriesPerMinute = 0;

switch (type)
{
    case 1:
        caloriesPerMinute = 60; 
        break;
    case 2:
        caloriesPerMinute = 40;  
        break;
    case 3:
        caloriesPerMinute = 55; 
        break;
    default:
        Console.WriteLine("Unknown exercise type.");
        return;
}

double totalCalories = caloriesPerMinute * duration;
Console.WriteLine($"Total calories burned: {totalCalories}");