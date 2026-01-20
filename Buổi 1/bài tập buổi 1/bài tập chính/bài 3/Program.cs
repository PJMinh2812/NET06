//Chuyển đổi thời gian từ phút sang giờ và phút
/*
Yêu cầu người dùng nhập vào một số phút và chuyển đổi số phút này thành giờ và phút. 
Ví dụ, nếu người dùng nhập vào 130 phút, kết quả sẽ là 2 giờ và 10 phút.
*/

//input:
// Enter minutes: 130
//process:
// hours = 130 / 60 = 2
// remainingMinutes = 130 % 60 = 10
//output:
// Hours: 2, minutes: 10

Console.Write($"Enter minutes:　");
double minutes = double.Parse(Console.ReadLine());

int hours = (int)(minutes / 60);

Console.WriteLine($"Hours: {hours}, minutes: {minutes % 60}");

