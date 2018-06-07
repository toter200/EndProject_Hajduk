using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcC_PartPicker
{
    /// <summary>
    /// Saves Data for a Computer Processor
    /// </summary>
    public class Cpu
    {
        /// <summary>
        /// Name of Manufacturer of the CPU
        /// </summary>
        public string Brand { get; private set; }
        /// <summary>
        /// Model name of CPU
        /// </summary>
        public string Model { get; private set; }
        /// <summary>
        /// Corecount of CPU
        /// </summary>
        public int Cores { get; private set; }
        /// <summary>
        /// Threadcount(int or bool)
        /// true = Corecount * 2
        /// </summary>
        public int Threads { get; private set; }
        /// <summary>
        /// Base frequency of CPU
        /// </summary>
        public float BaseClock { get; private set; }
        /// <summary>
        /// Maximum Frequency of CPU
        /// </summary>
        public float BoostClock { get; private set; }
        /// <summary>
        /// Compatible Motherboard Socket
        /// </summary>
        public string Socket { get; private set; }
        /// <summary>
        /// Powerdelivery to cpu 
        /// </summary>
        public int Tdp { get; private set; }
        /// <summary>
        /// Amount of Level 3 Cache if CPU
        /// </summary>
        public int L3Cahche { get; private set; }
        /// <summary>
        /// Maximum supoported Frequency of RAM
        /// </summary>
        public int MaxMemoryFreq { get; private set; }
        /// <summary>
        /// state of  overclock multiplikator
        /// </summary>
        public bool Unlocked { get; set; }

        public float Price { get; set; }



        /// <summary>
        /// Creating a new CPU entry
        /// </summary>
        /// <param name="brand">Name of Manufacturer of the CPU</param>
        /// <param name="model">Model name of CPU</param>
        /// <param name="cores">Corecount of CPU</param>
        /// <param name="threads">Threadcount(int or bool)
        ///                       true = Corecount * 2</param>
        /// <param name="baseClock">Base frequency of CPU</param>
        /// <param name="boostClock">Maximum Frequency of CPU</param>
        /// <param name="socket">Compatible Motherboard Socket</param>
        /// <param name="tdp">Powerdelivery to cpu</param>
        /// <param name="l3Cache">Amount of Level 3 Cache if CPU</param>
        /// <param name="maxmemfreq">Maximum supoported Frequency of RAM</param>
        /// <param name="unlocked">state of  overclock multiplikator</param>
        /// <param name="price">Price for Product</param>
        public Cpu(string brand, string model, int cores, int threads, float baseClock,float boostClock,
                   string socket, int tdp, int l3Cache, int maxmemfreq, bool unlocked, float price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Cores = cores;
            this.Threads = threads;
            this.BaseClock = baseClock;
            this.BoostClock = boostClock;
            this.Socket = socket;
            this.Tdp = tdp;
            this.L3Cahche = l3Cache;
            this.MaxMemoryFreq = maxmemfreq;
            this.Unlocked = unlocked;
            this.Price = price;
        }
        /// <summary>
        /// Creating a new CPU entry
        /// </summary>
        /// <param name="brand">Name of Manufacturer of the CPU</param>
        /// <param name="model">Model name of CPU</param>
        /// <param name="cores">Corecount of CPU</param>
        /// <param name="threads">Threadcount(int or bool)
        ///                       true = Corecount * 2</param>
        /// <param name="baseClock">Base frequency of CPU</param>
        /// <param name="boostClock">Maximum Frequency of CPU</param>
        /// <param name="socket">Compatible Motherboard Socket</param>
        /// <param name="tdp">Powerdelivery to cpu</param>
        /// <param name="l3Cache">Amount of Level 3 Cache if CPU</param>
        /// <param name="maxmemfreq">Maximum supoported Frequency of RAM</param>
        /// <param name="unlocked">state of  overclock multiplikator</param>
        /// <param name="price">Price for Product</param>
        public Cpu(string brand, string model, int cores, bool threads, float baseClock, bool unlocked,
                   float boostClock, string socket, int tdp, int l3Cache, int maxmemfreq, float price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Cores = cores;
            if (threads == true)
            {
                this.Threads = this.Cores * 2;
            }
            else if (true)
            {
                this.Threads = Cores;
            }
            this.BaseClock = baseClock;
            this.BoostClock = boostClock;
            this.Socket = socket;
            this.Tdp = tdp;
            this.L3Cahche = l3Cache;
            this.MaxMemoryFreq = maxmemfreq;
            this.Unlocked = unlocked;
            this.Price = price;
        }
        /// <summary>
        /// Creating a new CPU entry
        /// </summary>
        /// <param name="brand">Name of Manufacturer of the CPU</param>
        /// <param name="model">Model name of CPU</param>
        /// <param name="cores">Corecount of CPU</param>
        /// <param name="threads">Threadcount(int or bool)
        ///                       true = Corecount * 2</param>
        /// <param name="baseClock">Base frequency of CPU</param>
        /// <param name="boostClock">Maximum Frequency of CPU</param>
        /// <param name="socket">Compatible Motherboard Socket</param>
        /// <param name="tdp">Powerdelivery to cpu</param>
        /// <param name="l3Cache">Amount of Level 3 Cache if CPU</param>
        /// <param name="maxmemfreq">Maximum supoported Frequency of RAM</param>
        /// <param name="price">Price for Product</param>
        public Cpu(string brand, string model, int cores, int threads, float baseClock,
                   float boostClock, string socket, int tdp, int l3Cache, int maxmemfreq, float price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Cores = cores;
            this.Threads = threads;
            this.BaseClock = baseClock;
            this.BoostClock = boostClock;
            this.Socket = socket;
            this.Tdp = tdp;
            this.L3Cahche = l3Cache;
            this.MaxMemoryFreq = maxmemfreq;
            this.Unlocked = false;
            this.Price = price;
        }


    }
}
