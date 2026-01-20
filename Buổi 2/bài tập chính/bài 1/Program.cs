/*
Bài 1:
Tình huống: Bạn đang xây dựng một ứng dụng ghi lại nhiệt độ trong ngày để hỗ trợ cảnh báo thời tiết. Khi
người dùng nhập vào một con số biểu thị nhiệt độ (°C), hệ thống cần phải phản hồi:
Nếu nhiệt độ lớn hơn 0 → hiển thị “🌤️ Trời ấm”
Nếu nhiệt độ nhỏ hơn 0 → hiển thị “❄️ Trời lạnh, có thể có băng giá!”
Nếu nhiệt độ bằng 0 → hiển thị “🌫️ Trời rất lạnh, đúng 0°C!”
*/

//input: nhiệt độ (°C)
//process: kiểm tra nhiệt độ nếu lớn hơn 0, nhỏ hơn 0 hoặc bằng 0 thì in ra trang thái thời tiết
//output: thông báo về tình trạng thời tiết

Console.Write("Nhập nhiệt độ(°C): ");
double temperature = double.Parse(Console.ReadLine());

if (temperature > 0)
{
    Console.WriteLine($"🌤️ Trời ấm");   
}
else if (temperature < 0)
{
    Console.WriteLine($"❄️ Trời lạnh, có thể có băng giá!");
}
else
{
    Console.WriteLine("🌫️ Trời rất lạnh, đúng 0°C!");
}