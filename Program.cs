//1
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Adinizi daxil edin: ");
        string ad = Console.ReadLine();

        Console.Write("Yasinizi daxil edin: ");
        int yas = int.Parse(Console.ReadLine());

        Console.Write("Boyunuzu daxil edin: ");
        double boy = double.Parse(Console.ReadLine());

        Console.WriteLine($"Salam, menim adim {ad}-dir. Menim {yas} yasim var, boyum {boy} m-dir.");
    }
}*/
//2
/*using System;

class Program
{
    static void Main()
    {
        const double Pi = 3.14159;

        Console.Write("Radiusu daxil edin: ");
        double radius = double.Parse(Console.ReadLine());

        double sahe = Pi * radius * radius;

        Console.WriteLine($"Dairenin sahesi: {sahe}");
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        const double USD = 1.7;
        const double EUR = 1.82;

        Console.Write("Manat meblegini daxil edin: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double manat))
        {
            double dollar = manat / USD;
            double avro = manat / EUR;

            Console.WriteLine($"Dollar: {dollar:F2} USD");
            Console.WriteLine($"Avro: {avro:F2} EUR");
        }
        else
        {
            Console.WriteLine("Sehv deyer daxil etdiniz!");
        }
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("1-ci fennin qiymetini daxil edin: ");
        string qiymet1 = Console.ReadLine();

        Console.Write("2-ci fennin qiymetini daxil edin: ");
        string qiymet2 = Console.ReadLine();

        Console.Write("3-cu fennin qiymetini daxil edin: ");
        string qiymet3 = Console.ReadLine();

        Console.Write("4-cu fennin qiymetini daxil edin: ");
        string qiymet4 = Console.ReadLine();

        Console.Write("5-ci fennin qiymetini daxil edin: ");
        string qiymet5 = Console.ReadLine();

        int q1 = int.Parse(qiymet1);
        int q2 = int.Parse(qiymet2);
        int q3 = int.Parse(qiymet3);
        int q4 = int.Parse(qiymet4);
        int q5 = int.Parse(qiymet5);

        double orta = (q1 + q2 + q3 + q4 + q5) / 5.0;

        Console.WriteLine($"Orta bal: {orta}");

        if (orta < 51)
        {
            Console.WriteLine("Kesildiniz");
        }
        else if (orta <= 90)
        {
            Console.WriteLine("Orta netice");
        }
        else
        {
            Console.WriteLine("Ela netice");
        }
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        const double faiz = 0.12;

        Console.Write("Ilkin meblegi daxil edin: ");
        double mebleg = double.Parse(Console.ReadLine());

        Console.Write("Nece il saxlayacaginizi daxil edin: ");
        int il = int.Parse(Console.ReadLine());

        double gelecekMebleg = mebleg * (1 + faiz * il);

        Console.WriteLine($"Gelecek mebleg: {gelecekMebleg}");
    }
}*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Mesafeni (km) daxil edin: ");
        double mesafe = double.Parse(Console.ReadLine());

        Console.Write("Serf olunan yanacagi (litr) daxil edin: ");
        double yanacaq = double.Parse(Console.ReadLine());

        if (mesafe <= 0 || yanacaq <= 0)
        {
            Console.WriteLine("Mesafe ve yanacaq 0-dan boyuk olmalidir.");
        }
        else
        {
            double serfiyyat = (yanacaq / mesafe) * 100;

            Console.WriteLine($"100 km ucun yanacaq serfiyyati: {serfiyyat:F2} litr");
        }
    }
}