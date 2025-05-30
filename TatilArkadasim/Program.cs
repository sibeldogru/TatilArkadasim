
using System.Collections;

string choice1 = "Bodrum";
string choice2 = "Marmaris";
string choice3 = "Çeşme";

int choice1Price = 4000;
int choice2Price = 3000;
int choice3Price = 5000;

int transportationPrice1 = 1500;
int transportationPrice2 = 4000;

string answer = "evet";

do
{
    Console.WriteLine("Yol Arkadaşı Uygulamasına Hoş Geldiniz!");
    Console.WriteLine("Lütfen tatil lokasyonunuzun ismini yazınız.");
    Console.WriteLine("1 - Bodrum");
    Console.WriteLine("2 - Marmaris");
    Console.WriteLine("3 - Çeşme");

    string usersChoice = Console.ReadLine().ToLower();


    while (usersChoice != choice1.ToLower() && usersChoice != choice2.ToLower() && usersChoice != choice3.ToLower())
    {
        Console.WriteLine("Geçersiz bir lokasyon girdiniz.");
        Console.WriteLine("Lütfen tatil lokasyonunuzun ismini yazınız.");
        Console.WriteLine("1 - Bodrum");
        Console.WriteLine("2 - Marmaris");
        Console.WriteLine("3 - Çeşme");
        usersChoice = Console.ReadLine().ToLower();

    }

    Console.WriteLine("Tatile kaç kişi gideceksiniz?");
    int guest = Convert.ToInt32(Console.ReadLine());

    switch (usersChoice)
    {
        case "bodrum":
            Console.WriteLine("Bodrum, Ege Denizi kıyısında yer alan popüler bir tatil beldesidir. Beyaz evleri, mavi denizi ve tarihi yapılarıyla ünlüdür. Bodrum'da denize girebilir, tekne turuna çıkabilir, tarihi yerleri gezebilir, gece hayatının tadını çıkarabilirsiniz.");
            break;
        case "marmaris":
            Console.WriteLine("Marmaris, Ege ve Akdeniz’in birleştiği noktada bulunan popüler bir tatil beldesidir. Doğal koyları, yat limanı ve çam ormanlarıyla çevrili yapısıyla öne çıkar. Marmaris'te denize girebilir, tekne turuna çıkabilir, doğayla iç içe olabilir, Marmaris Kalesi'ni gezebilirsiniz.");
            break;
        case "çeşme":
            Console.WriteLine("Çeşme, İzmir’in batısında yer alan, Ege Denizi kıyısında ünlü bir tatil beldesidir. Rüzgarlı havası, plajları ve lüks tatil köyleriyle tanınır. Çeşme'de sörf yapabilir, denize gireilir, gece hayatının tadını çıkarabilir, lezzet keşfi yapabilirsiniz.");
            break;
    }

    Console.WriteLine("Tatile ne şekilde gideceksiniz?");
    Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
    Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
    Console.WriteLine("Lütfen cevabı 1 ya da 2 olarak giriniz.");
    int transportationChoice = Convert.ToInt32(Console.ReadLine());
    int transportationChoice1 = 1;
    int transportationChoice2 = 2;


    int j = 0;
    while (transportationChoice != transportationChoice1 && transportationChoice != transportationChoice2)
    {
        Console.WriteLine("Geçersiz bir ulaşım şekli girdiniz.Lütfen tekrar giriniz");
        Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
        Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
        Console.WriteLine("Lütfen cevabı 1 ya da 2 olarak giriniz.");
        transportationChoice = Convert.ToInt32(Console.ReadLine());
        j++;
    }

    int locationPrice = 0;
if (usersChoice == choice1.ToLower())
    locationPrice = choice1Price;
else if (usersChoice == choice2.ToLower())
    locationPrice = choice2Price;
else if (usersChoice == choice3.ToLower())
    locationPrice = choice3Price;

int transportPrice = (transportationChoice == 1) ? transportationPrice1 : transportationPrice2; 

int totalPrice = (locationPrice + transportPrice) * guest;

Console.WriteLine("Tatil gideriniz şu şekilde -> " + totalPrice + " TL");

Console.WriteLine("Başka bir tatil planlamak istiyor musunuz? Lütfen evet ya da hayır yazınız.");
answer = Console.ReadLine().ToLower();

} while (answer == "evet");

Console.WriteLine("Tatil planlayıcısını kullandığınız için teşekkürler!");

