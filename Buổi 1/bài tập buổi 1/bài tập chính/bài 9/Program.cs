//  Chuyển đổi từ km/h sang m/s
/*
Yêu cầu người dùng nhập vào vận tốc bằng km/h và chuyển đổi nó sang m/s theo công thức: m/s = km/h ÷ 3.6. 
In ra kết quả sau khi chuyển đổi.
*/

//input:
// Enter speed in km/h: 90
//process:
// speedM_s = 90 / 3.6 = 25
//output:
// Speed in m/s: 25 m/s

Console.WriteLine($"Enter speed in km/h: ");
double speedKm_h = double.Parse(Console.ReadLine());

double speedM_s = speedKm_h / 3.6;
Console.WriteLine($"Speed in m/s: {speedM_s} m/s");