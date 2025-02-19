int sifreUzunlugu = 0;
bool ozelKarakterVar = false;
bool buyukHarfVar = false;

Console.Write("Lütfen bir şifre girin: ");
string sifre = Console.ReadLine();

if (sifre.Length < 8)
{
    Console.WriteLine("Şifre en az 8 karakter uzunluğunda olmalıdır.");
}

foreach (char karakter in sifre)
{
    if (karakter == '@' || karakter == '#' || karakter == '$' || karakter == '%')
    {
        ozelKarakterVar = true;
        break;
    }
}

if (!ozelKarakterVar)
{
    Console.WriteLine("Şifre en az bir özel karakter içermelidir (@, #, $, % gibi).");
}

foreach (char karakter in sifre)
{
    if (char.IsUpper(karakter))
    {
        buyukHarfVar = true;
        break;
    }
}

if (!buyukHarfVar)
{
    Console.WriteLine("Şifre en az bir büyük harf içermelidir.");
}

if (sifre.Length >= 8 && ozelKarakterVar && buyukHarfVar)
{
    Console.WriteLine("Şifre güçlü!");
}
else
{
    Console.WriteLine("Şifre zayıf.");
}
