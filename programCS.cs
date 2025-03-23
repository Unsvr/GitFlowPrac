using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Привіт! Як тебе звати?");
        string name = Console.ReadLine();
        Console.WriteLine($"Радий знайомству, {name}!");
    }
}