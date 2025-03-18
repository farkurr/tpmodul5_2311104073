using System;

class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine($"Halo user {nama}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Farhan");  // Ganti dengan nama panggilanmu

        Console.ReadKey();
    }
}
