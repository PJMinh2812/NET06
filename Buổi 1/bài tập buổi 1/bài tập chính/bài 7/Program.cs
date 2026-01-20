// Tính tốc độ trung bình

/*
Yêu cầu người dùng nhập vào quãng đường đã đi (km) và thời gian đã đi (giờ). 
Tính và in ra tốc độ trung bình (km/h).
*/

//input:
// Enter distance (km): 150 
// Enter time (hours): 3
//process:
// averageSpeed = 150 / 3 = 50
//output:
// Average speed: 50 km/h


Console.WriteLine($"Enter distance (km): ");
double distance = double.Parse(Console.ReadLine());

Console.WriteLine($"Enter time (hours): ");
double time = double.Parse(Console.ReadLine());

double averageSpeed = distance / time;

Console.WriteLine($"Average speed: {averageSpeed} km/h");