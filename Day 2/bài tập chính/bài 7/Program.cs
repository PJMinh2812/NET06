/*
Tình huống – “Hệ thống đặt vé rạp chiếu phim”
Bạn đang phát triển một ứng dụng đặt vé xem phim online. 
Khi người dùng chọn hạng vé (Standard, Premium, VIP),
hệ thống sẽ hiển thị thông tin về tiện ích mà họ nhận được kèm theo vé.

Hạng vé                 Tiện ích kèm theo
Standard            Ghế ngồi thường, không có đồ uống
Premium             Ghế ngồi thoải mái, có đồ uống miễn phí
VIP                 Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí
*/
//input: hạng vé (Standard, Premium, VIP)
//process: kiểm tra hạng vé để hiển thị tiện ích kèm theo
//output: tiện ích kèm theo hạng vé đã chọn
Console.Write("Nhập hạng vé (Standard, Premium, VIP): ");
string type = Console.ReadLine().ToLower();   
     


switch (type)
{
    case "standard":
        Console.WriteLine("Tiện ích kèm theo: Ghế ngồi thường, không có đồ uống");
        break;
    case "premium":
        Console.WriteLine("Tiện ích kèm theo: Ghế ngồi thoải mái, có đồ uống miễn phí");
        break;
    case "vip":
        Console.WriteLine("Tiện ích kèm theo: Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí");
        break;
    default:
        Console.WriteLine("Hạng vé không hợp lệ");
        break;
}