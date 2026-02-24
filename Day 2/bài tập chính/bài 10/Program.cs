/*
✈️ Tình huống – “Xác định tiện ích theo loại vé máy bay”
Bạn đang xây dựng một hệ thống đặt vé máy bay online. Khi hành khách chọn loại vé (Economy, Business hoặc
First Class), hệ thống cần hiển thị tiện ích tương ứng như sau:

Loại vé                     Tiện ích đi kèm
Economy                     Ghế thường
Business                    Ghế rộng
First Class                 Ghế sang trọng
*/
//input: loại vé (Economy, Business, First Class)
//process: kiểm tra loại vé để hiển thị tiện ích đi kèm
//output: tiện ích đi kèm loại vé đã chọn


Console.Write("Nhập loại vé (Economy, Business, First Class): ");
string ticketType = Console.ReadLine().ToLower();

switch (ticketType)
{
    case "economy":
        Console.WriteLine("Tiện ích đi kèm: Ghế thường");
        break;
    case "business":
        Console.WriteLine("Tiện ích đi kèm: Ghế rộng");
        break;
    case "first class":
        Console.WriteLine("Tiện ích đi kèm: Ghế sang trọng");
        break;
    default:
        Console.WriteLine("Loại vé không hợp lệ");
        break;
}
