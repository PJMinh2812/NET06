// Tính số ngày trong tuần và số ngày lẻ

/*
Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao nhiêu ngày lẻ còn lại. 
Ví dụ, nếu người dùng nhập vào 10 ngày, kết quả sẽ là 1 tuần và 3 ngày.
*/

Console.Write($"Enter number of days: ");
int days = int.Parse(Console.ReadLine());

int weeks = days / 7;
int remainingDays = days % 7;

Console.WriteLine($"Number of weeks: {weeks}, Remaining days: {remainingDays}");

//input:    
// Enter number of days: 10
//process:
// weeks = 10 / 7 = 1
// remainingDays = 10 % 7 = 3
//output:
// Number of weeks: 1, Remaining days: 3    
