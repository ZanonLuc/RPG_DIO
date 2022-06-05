using RpgDio.Entities;
using System;

namespace RpgDio
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "Fire Wizard");
            Archer archer = new Archer("Legolas", 34, "Basic Archer");

            Console.WriteLine(arus.Attack(4));
            Console.WriteLine(wizard.Attack(2));
            Console.WriteLine(archer.Attack());

           
        }
    }
}