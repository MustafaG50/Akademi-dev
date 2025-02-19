Console.WriteLine("1. Sayıyı giriniz :");
int sayı1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı giriniz :");
int sayı2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yapmak istediğiniz işlemi giriniz. Örn(+,-,*,/) :");
char işlem = Convert.ToChar(Console.ReadLine());
int sonuç = 0;
switch (işlem)
{
    case '+':
        sonuç = sayı1 + sayı2;
        Console.WriteLine($"İşlem Sonucu : {sonuç}");
        break;
    case '-':
        sonuç = sayı1 - sayı2;
        Console.WriteLine($"İşlem Sonucu : {sonuç}");
        break;
    case '*':
        sonuç = sayı1 * sayı2;
        Console.WriteLine($"İşlem Sonucu : {sonuç}");
        break;
    case '/':
        sonuç = sayı1 / sayı2;
        Console.WriteLine($"İşlem Sonucu : {sonuç}");
        break;
    default:
        Console.WriteLine("Doğru işlemi seçiniz.");
        break;
}
