Console.WriteLine("****************************************");
Console.WriteLine();
Console.WriteLine("BİLGİ YARIŞMASINA HOŞGELDİNİZ");
Console.WriteLine();
Console.WriteLine("****************************************");
Console.WriteLine();
Console.WriteLine("Başlamak için Lütfen 1 e basınız.");

int soru;
soru = Convert.ToInt32(Console.ReadLine());
if( soru == 1)
{
    Console.WriteLine("Türkiye'nin Başkenti neresidir ?");
    Console.WriteLine();
    Console.WriteLine("A) İstanbul");
    Console.WriteLine();
    Console.WriteLine("B) Ankara"); 
    Console.WriteLine();
    Console.WriteLine("C) İzmir");
    Console.WriteLine();
    Console.WriteLine("D) Bursa");
    char cevap=Convert.ToChar(Console.ReadLine());
    if(cevap == 'b'||cevap == 'B')
    {
        Console.WriteLine("Doğru Cevap Bir Sonra Ki Soruya Geçebilrsiniz");
        soru++;
    }
    else
    {
        Console.WriteLine("Cevabınız Yanlış Elendiniz !");
    }
}
if(soru == 2)
{
    Console.WriteLine("Türkiye Cumhuriyeti Devleti Ne Zaman Kuruldu ?");
    Console.WriteLine();
    Console.WriteLine("A) 29 Ekim 1920");
    Console.WriteLine();
    Console.WriteLine("B) 23 Nisan 1920");
    Console.WriteLine();
    Console.WriteLine("C) 29 Ekim 1923");
    Console.WriteLine();
    Console.WriteLine("D) 23 Nisan 1923");
    char cevap = Convert.ToChar(Console.ReadLine());
    if (cevap == 'c' || cevap == 'C')
    {
        Console.WriteLine("Doğru Cevap Bir Sonra Ki Soruya Geçebilrsiniz");
        soru++;
    }
    else
    {
        Console.WriteLine("Cevabınız Yanlış Elendiniz !");
    }
}
if (soru == 3)
{
    Console.WriteLine("x*y=6, y tek sayı olduğuna göre x nedir?");
    Console.WriteLine();
    Console.WriteLine("A) Tek");
    Console.WriteLine();
    Console.WriteLine("B) Çift");
    Console.WriteLine();
    Console.WriteLine("C) Tanımsız");
    Console.WriteLine();
    Console.WriteLine("D) Hiçbiri");
    char cevap = Convert.ToChar(Console.ReadLine());
    if (cevap == 'B' || cevap == 'b')
    {
        Console.WriteLine("Doğru Cevap Bir Sonra Ki Soruya Geçebilrsiniz");
        soru++;
    }
    else
    {
        Console.WriteLine("Cevabınız Yanlış Elendiniz !");
    }
}

