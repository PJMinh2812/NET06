/*
🔤 Tình huống – “Phân loại chữ cái: nguyên âm hay phụ âm”
Bạn đang phát triển một trò chơi học chữ cái tiếng Anh cho trẻ em. 
Khi người dùng nhập vào một ký tự, chương trình sẽ tự động phân loại:
Nếu ký tự là nguyên âm (a, e, i, o, u – 
không phân biệt hoa/thường) → in ra “✅ Là nguyên âm”
Ngược lại → in “🔠 Là phụ âm”
*/
// input: một ký tự
// process: kiểm tra ký tự đó là nguyên âm hay phụ âm
// output: kết quả phân loại ký tự
Console.Write("Nhập một ký tự: ");
char character = char.Parse(Console.ReadLine().ToLower());

if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
{
    Console.WriteLine($"✅ Là nguyên âm");
}
else
{
    Console.WriteLine($"🔠 Là phụ âm");
}

