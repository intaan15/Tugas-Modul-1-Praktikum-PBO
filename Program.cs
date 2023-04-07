using System;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        Laptop laptop2 = new IdeaPad();
        Predator predator = new Predator();
        Laptop acer = new Predator();
        Processor processor = new Processor();

        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        laptop1.Ngoding();
        acer.BermainGame();
        predator.BermainGame();
        processor.Spesifikasi();
    }
}

public class Processor
{
    public string Merk1 { get; set; }
    public string Merk2 { get; set; }
    public string Tipe1 { get; set; }
    public string Tipe2 { get; set; }
    public string Tipe3 { get; set; }
    public void Spesifikasi()
    {
        Console.WriteLine($"Memiliki VGA {Merk2} Merk Processornya {Merk1} dan tipe processornya {Tipe2}");
    }
}

public class Intel : Processor
{
    public Intel()
    {
        Merk1 = "Intel";
        Tipe1 = "Core i3";
        Tipe2 = "Core i5";
        Tipe3 = "Core i7";
    }
}

public class AMD : Processor
{
    public AMD()
    {
        Merk1 = "AMD";
        Tipe1 = "RAYZEN";
        Tipe2 = "ATHLON";
    }
}

public class Vga
{
    public string Merk2 { get; set; }
    public string Merk3 { get; set; }
}

public class Nvidia : Vga
{
    public Nvidia()
    {
        Merk2 = "Nvidia";
    }
}

public class AMD2 : Vga
{
    public AMD2()
    {
        Merk3 = "AMD";
    }
}

public class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}


public class Asus : Laptop
{
    public Asus()
    {
        Merk = "Asus";
    }
}

public class ROG : Asus
{
    public ROG()
    {
        Tipe = "ROG";
    }
}

public class Vivobook : Asus
{
    public Vivobook()
    {
        Tipe = "Vivobook";
    }
}

public class Lenovo : Laptop
{
    public Lenovo()
    {
        Merk = "Lenovo";
    }
}

public class Legion : Lenovo
{
    public Legion()
    {
        Tipe = "Legion";
    }
}
public class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        Tipe = "IdeaPad";
    }
}

public class Acer : Laptop
{
    public Acer()
    {
        Merk = "Acer";
    }
}

public class Swift : Acer
{
    public Swift()
    {
        Tipe = "Swift";
    }
}

public class Predator : Acer
{
    public Predator()
    {
        Tipe = "Predator";
    }
}