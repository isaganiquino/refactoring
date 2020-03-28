using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class ElectricKettle
    {
        private ElectricKettle() { }

        private static readonly Lazy<ElectricKettle> instance = new Lazy<ElectricKettle>(() => new ElectricKettle());
        public static ElectricKettle Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public static Status KettleStatus { get; set; }

        public void Start()
        {
            Console.WriteLine("Starting...");
            Thread.Sleep(1000);
            KettleStatus = Status.Empty;
        }

        public void Fill()
        {
            if (KettleStatus == Status.Empty)
            {
                Console.WriteLine("Filling...");
                Thread.Sleep(2000);
                KettleStatus = Status.Filled;
            }
        }

        public void Boil()
        {
            if (KettleStatus == Status.Filled)
            {
                Console.WriteLine("Boiling...");
                KettleStatus = Status.InProgress;
                Thread.Sleep(4000);

                KettleStatus = Status.Boiled;
            }
        }

        public void Drain()
        {
            if (KettleStatus == Status.Boiled)
            {
                Console.WriteLine("Draining...");
                Thread.Sleep(2000);
                KettleStatus = Status.Empty;
            }
        }
    }
}
