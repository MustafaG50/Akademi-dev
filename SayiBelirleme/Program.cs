Console.WriteLine("Bir sayı giriniz :");
int sayı = Convert.ToInt32(Console.ReadLine());

if (sayı > 0)
    Console.WriteLine($"{sayı} bir pozitif sayıdır.");
else if (sayı < 0)
    Console.WriteLine($"{sayı} bir negatif sayıdır.");
else
    Console.WriteLine("Sayı 0'a eşittir.");
