using System;
using System.Threading;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string varietyInput = string.Empty;
            string pizzeria = string.Empty;
            string variety = string.Empty;
            PizzeriaFactory factory = null;

            Console.WriteLine("Welcome to Pizzeria Factory App!\n\n");
            Console.WriteLine("List of pizza variety\n\n1. Cheese Pizza\n2. Clam Pizza\n3. Veggies Pizza\n");
            Console.Write("Choose your desired pizza: ");

            varietyInput = Console.ReadLine();

            if (varietyInput == "1")
                variety = Variety.Cheese;
            else if (varietyInput == "2")
                variety = Variety.Clam;
            else variety = Variety.Veggies;

            Console.WriteLine("\nList of Pizzerias\n\n1. Pizzeria A\n2. Pizzeria B\n");
            Console.Write("Choose your desired pizzeria: ");

            pizzeria = Console.ReadLine();

            if (pizzeria == "1")
                factory = new PizzeriaAFactory();
            else
                factory = new PizzeriaBFactory();

            factory.Order(variety);
            Thread.Sleep(1000);

            factory.Prepare();
            Thread.Sleep(1000);

            factory.Bake();
            Thread.Sleep(1000);

            factory.Cut();
            Thread.Sleep(1000);

            factory.Box();
            Thread.Sleep(1000);

            Console.WriteLine("\nThank you for using this Kettle App.\nPress any key to exit! ");
            Console.ReadLine();
        }
    }
}
