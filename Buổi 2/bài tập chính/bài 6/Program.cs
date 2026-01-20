/*
Tình huống – “Tính tiền điện cho hộ gia đình”
Bạn đang xây dựng một chương trình hỗ trợ tính tiền điện hàng tháng cho các hộ gia đình. Khi người dùng
nhập vào số điện tiêu thụ trong tháng (tính bằng kWh), chương trình sẽ tính tiền điện phải trả theo biểu giá đơn
giản hóa sau:

Mức tiêu thụ (kWh)          Đơn giá
                           (VND/kWh)                   
Dưới 100 kWh                1.500
Từ 100 đến 200kWh           2.000
Trên 200 kWh                2.500

*/

//input: số điện tiêu thụ trong tháng (kWh)
//process: kiểm tra số điện tiêu thụ để tính tiền điện theo biểu giá
//output: tổng tiền điện phải trả

Console.Write("Nhập số điện tiêu thụ trong tháng (kWh): ");
int consumption = int.Parse(Console.ReadLine());  

double total = 0;

if (consumption < 100)
{
    total = consumption * 1500;
}
else if (consumption >= 100 && consumption <= 200)
{
    total = (100 * 1500) + ((consumption - 100) * 2000);
}
else
{
    total = (100 * 1500) + (100 * 2000) + ((consumption - 200) * 2500);
}

Console.WriteLine($"Tổng tiền điện phải trả: {total} VND");