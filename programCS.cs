using System;

namespace UserApp
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Greet()
        {
            Console.WriteLine($"Привіт, {Name}! Тобі {Age} років.");
        }
    }

    class Program
    {
        static void Main(string[] args)

            Console.Write("Введіть своє ім'я: ");
            string name = Console.ReadLine();

            Console.Write("Введіть свій вік: ");
            int age = int.Parse(Console.ReadLine());

            User user = new User(name, age);
            user.Greet();
            
            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }