/*
Tình huống – “Tính tiền taxi cho khách hàng”
Bạn đang viết một ứng dụng cho hãng taxi giúp tự động tính tiền cước dựa vào số km mà khách đã đi. Biểu giá
tính như sau:

Quãng đường                     Đơn giá (VND/km)
1 km đầu tiên                   10.000 VND
Từ km thứ 2 đến km thứ 5        8.000 VND/km
Từ km thứ 6 trở đi              6.000 VND/km
*/ 


Console.Write("Nhập số km đã đi: ");
int distance = int.Parse(Console.ReadLine());

double total = 0;

if (distance <= 1)
{
    total = distance * 10000;
}
else if (distance > 1 && distance <= 5)
{
    total = (1 * 10000) + ((distance - 1) * 8000);
}
else
{
    total = (1 * 10000) + (4 * 8000) + ((distance - 5) * 6000);
}

Console.WriteLine($"Tổng tiền cước taxi: {total} VND");