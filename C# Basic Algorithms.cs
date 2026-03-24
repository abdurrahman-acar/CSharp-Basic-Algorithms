////Taksimetre hesaplama örneği

double tl = 13.20;
Console.WriteLine("Kaç KM yol gideceksiniz");
double km = Convert.ToDouble(Console.ReadLine());

if(km * tl + 15 <= 100)
{
    Console.WriteLine("Ücretiniz 100 TL");
}
else
{
    double hesap = km * tl + 15;
    Console.WriteLine($"Ücretiniz {hesap} TL'dir");
}

///// Uçak Bileti Hesaplama Örnek


double price = 0.10;


Console.WriteLine("Yolculuk Yapacağınız Yer Kaç Mil Uzaklıkta");
int mil = Convert.ToInt32(Console.ReadLine());
while (mil < 0)
{
    Console.WriteLine("Lütfen Pozitif değer giriniz");
    mil = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Yaşınızı Giriniz");
int yas = Convert.ToInt32(Console.ReadLine());
while (yas < 0)
{
    Console.WriteLine("Lütfen Pozitif değer giriniz");
    yas = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Yolculuk Tipini Seçin 1 : Tek Yön , 2 : Çift Yön");
int tip = Convert.ToInt32(Console.ReadLine());
while (tip != 1 && tip != 2)
{
    Console.WriteLine("Lütfen Yalnızca 1 yada 2 numaralı sayıyı giriniz");
    tip = Convert.ToInt32(Console.ReadLine());
}



double hesap = mil * price;
double yas_indirim = 0;

if(yas < 12)
{
    yas_indirim = 0.50;
}
else if (yas >= 12 || yas <=24)
{
    yas_indirim = 0.10;
}
else if(yas > 65)
{
    yas_indirim = 0.30;
}

hesap -= (hesap * yas_indirim);

if(tip == 2)
{
    hesap -= (hesap * 0.20);
    hesap *= 2;
}



Console.WriteLine($"Ödemeniz gereken tutar : {hesap}");



///// Kuvvet Örnek

Console.WriteLine("Bir sayı Giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

for(int i = 3; i <= sayi; i *= 3)
{
    Console.WriteLine(i);
}

///////// Faktoriyel örnek

Console.WriteLine("Hesaplanacak sayıyı giriniz : ");
int sayi = Convert.ToInt32(Console.ReadLine());

int faktoriyel = 1;
for (int i = 1; i <= sayi ; i++)
{
    faktoriyel *= i;
}
Console.WriteLine($"Faktoriyel : {faktoriyel}");


///// Asal Sayı Örnek


Console.WriteLine("Sayı Giriniz :");
int sayi = Convert.ToInt32(Console.ReadLine());

for(int i = 2; i <= sayi; i++)
{ 
    bool isPrime = true;
    for(int j = 2; j < i; j++)
    {
       
        if(i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(i);
    }
}


/////// EBOB ve EKOK Hesaplama

Console.WriteLine("1. Sayıyı Giriniz :");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı Giriniz :");
int n2 = Convert.ToInt32(Console.ReadLine());

int ek = (n1 < n2) ? ek = n1 : ek = n2; ;
int ebob = 0;
for (int i = 1; i <= ek; i++)
{
    if (n1 % i == 0 &&  n2 % i == 0)
    {
        ebob = i;
    }
    
}

Console.WriteLine($"İki Sayının EBOB'u : {ebob}");
Console.WriteLine($"İki Sayının EKOK'u : {n1 * n2 / ebob}");
