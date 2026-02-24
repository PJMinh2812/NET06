/*
Bài 5: 🔍 Tình huống – “Lọc số đặc biệt cho hệ thống bảo mật”
Bạn đang phát triển một hệ thống tạo mật khẩu bảo mật, trong đó chỉ chấp nhận những con số “đặc biệt”
– tức
là số nguyên tố.
Để đảm bảo tính chính xác, bạn cần viết một chương trình giúp kiểm tra xem một số nguyên người dùng nhập
vào có phải là số nguyên tố hay không.
*/ 

//input: một số nguyên
//process: kiểm tra số nguyên đó có phải là số nguyên tố hay không
//output: kết quả kiểm tra số nguyên tố


Console.Write("Nhập một số nguyên: ");
int number = int.Parse(Console.ReadLine());
bool isPrime = true;

if (number <= 1)
{
    isPrime = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime == true)
{
    Console.WriteLine($"Số này là số nguyên tố");
}
else
{
    Console.WriteLine($"Số này không phải là số nguyên tố");
}


