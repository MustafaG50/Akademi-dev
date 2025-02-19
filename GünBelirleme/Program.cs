
Console.WriteLine("Gün ismi giriniz :");
string gün = Console.ReadLine();


switch (gün)
{
	case "Pazartesi":
        Console.WriteLine("Bugün Pazartesidir.");
			break;
    case "Salı":
        Console.WriteLine("Bugün Salıdır.");
            break;
    case "Çarşamba":
        Console.WriteLine("Bugün Çarşambadır.");
            break;
    case "Perşembe":
        Console.WriteLine("Bugün Perşembedir.");
        break;
    case "Cuma":
        Console.WriteLine("Bugün Cumadır.");
        break;
    case "Cumartesi":
        Console.WriteLine("Bugün Cumartesidir.");
        break;
    case "Pazar":
        Console.WriteLine("Bugün Pazardır.");
        break;
    default:
        Console.WriteLine("Gün ismini doğru giriniz.");
        break;
}
