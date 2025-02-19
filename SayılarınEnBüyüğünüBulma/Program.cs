Console.WriteLine("1. Sayıyı Giriniz :");
int sayı1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı Giriniz :");
int sayı2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. Sayıyı Giriniz :");
int sayı3 = Convert.ToInt32(Console.ReadLine());

if (sayı1 > sayı2)
{
    if (sayı1 > sayı3)
    {
        Console.WriteLine($"{sayı1} en büyük sayıdır.");
    }
    else
    {
        Console.WriteLine($"{sayı3} en büyük sayıdır.");
    }
}
else if (sayı2 > sayı3)
{
    Console.WriteLine($"{sayı2} en büyük sayıdır.");
}
else
{
    Console.WriteLine($"{sayı3} en büyük sayıdır.");
}