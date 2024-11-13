using System;

public abstract class Celular
{
    // Propriedades comuns a todos os celulares
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int Bateria { get; set; } // em percentual

    // Construtor
    public Celular(string marca, string modelo, string cor, int bateria)
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        Bateria = bateria;
    }

    // Método comum a todos os celulares
    public void Ligar()
    {
        Console.WriteLine($"{Marca} {Modelo} está ligando...");
    }

    public void Desligar()
    {
        Console.WriteLine($"{Marca} {Modelo} está desligando...");
    }

    // Método abstrato para ser implementado pelas subclasses
    public abstract void FuncionalidadeEspecial();
}

public class Samsung : Celular
{
    // Construtor da classe Samsung que usa o construtor da classe base
    public Samsung(string modelo, string cor, int bateria)
        : base("Samsung", modelo, cor, bateria)
    { }

    // Implementação do método abstrato
    public override void FuncionalidadeEspecial()
    {
        Console.WriteLine("Samsung oferece a funcionalidade de tela curva!");
    }
}

public class Apple : Celular
{
    // Construtor da classe Apple que usa o construtor da classe base
    public Apple(string modelo, string cor, int bateria)
        : base("Apple", modelo, cor, bateria)
    { }

    // Implementação do método abstrato
    public override void FuncionalidadeEspecial()
    {
        Console.WriteLine("Apple oferece a funcionalidade Face ID!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Criando instâncias de diferentes marcas
        Celular celularSamsung = new Samsung("Galaxy S22", "Preto", 85);
        Celular celularApple = new Apple("iPhone 13", "Branco", 95);

        // Usando os métodos comuns
        celularSamsung.Ligar();
        celularApple.Ligar();

        // Usando a funcionalidade específica de cada modelo
        celularSamsung.FuncionalidadeEspecial();
        celularApple.FuncionalidadeEspecial();

        // Usando o método comum para desligar
        celularSamsung.Desligar();
        celularApple.Desligar();
    }
}
