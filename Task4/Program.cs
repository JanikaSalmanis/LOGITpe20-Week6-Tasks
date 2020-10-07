using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "banana", "fork", "keyboard", "purse", "jar of mud" };

            Random rnd = new Random();
            Console.WriteLine($"{superHeroes[rnd.Next(0, superHeroes.Length)]} will fight ");
            Console.WriteLine($"with {superVillains[rnd.Next(0,superVillains.Length)]} ");
            Console.WriteLine($"weapon {weapon[rnd.Next(0,weapon.Length)]}");

            //Provide the following output -->
            //{random superhero} will fight {random Supervillain} with a {random weapon}
        }
    }
}
