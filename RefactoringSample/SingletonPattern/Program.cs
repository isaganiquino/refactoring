using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = string.Empty;
            var electricKettle = ElectricKettle.Instance;

            Console.Write("Electric Kettle\n\n\n");
            
            Console.Write("Press any key to start: ");
            action = Console.ReadLine();

            electricKettle.Start();
            electricKettle.Fill();
            electricKettle.Boil();
            electricKettle.Drain();

            Console.WriteLine("\nThank you for using this Kettle App.\nPress any key to exit! ");
            Console.ReadLine();
        }
    }
}
