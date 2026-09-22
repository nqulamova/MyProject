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
}