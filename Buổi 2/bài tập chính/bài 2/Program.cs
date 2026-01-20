/*
Bài 2:  Tình huống thực tế – "Tính thuế thu nhập cho người đi làm":
Bạn được giao xây dựng một phần mềm nhỏ để hỗ trợ kế toán công ty tính toán nhanh thuế thu nhập cá nhân
cho nhân viên mỗi tháng.
Kế toán chỉ cần nhập vào số tiền thu nhập hàng tháng, hệ thống sẽ tự động tính toán số thuế phải nộp theo
quy định sau:
Nếu thu nhập ≤ 5 triệu đồng → ✅ Miễn thuế
Nếu thu nhập > 5 triệu và ≤ 10 triệu đồng → 💰 Thuế 10%
Nếu thu nhập > 10 triệu đồng → 💸 Thuế 20%
*/ 


//input: số tiền thu nhập hàng tháng
//process: kiểm tra số tiền thu nhập để tính thuế theo quy định
//output: số tiền thuế phải nộp
Console.Write($"Nhập số tiền: ");
double salary = double.Parse(Console.ReadLine());
double total = 0;

if(salary <= 5_000_000)
{
    Console.WriteLine($"✅ Miễn thuế");
}
else if (5_000_000 < salary  && salary <= 10_000_000)
{
    total += (salary * 10) / 100;
    Console.WriteLine($"Số tiền phải nộp là: {total}");
}
else
{
    total += (salary * 20) / 100;
    Console.WriteLine($"Số tiền phải nộp là: {total}");
}

