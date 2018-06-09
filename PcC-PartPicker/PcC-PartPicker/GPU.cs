using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcC_PartPicker
{

    /// <summary>
    /// Saves Data for a Computer Graphics Processor
    /// </summary>
    class GPU
    {
        /// <summary>
        /// Manufacturer of GPU
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// PRoduct name 
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// Corecount of GPU
        /// </summary>
        public int Cores { get; private set; }

        /// <summary>
        /// Basic Frequency of GPU
        /// </summary>
        public float BaseFrequency { get; private set; }
        
        /// <summary>
        /// Maximum Frequency of GPU
        /// </summary>
        public float BoostFrequency { get; private set; }

        /// <summary>
        /// Power index based on Teraflops
        /// </summary>
        public decimal TeraFlops { get; private set; }

        /// <summary>
        /// Generation and type of Memory
        /// </summary>
        public string MemoryType { get; private set; }

        /// <summary>
        /// Amount of GB of RAM
        /// </summary>
        public int MemorySize { get; private set; }

        /// <summary>
        /// Basic frequency
        /// </summary>
        public float MemoryClock { get; private set; }

        /// <summary>
        /// Connection between CPU RAM and GPU RAM 
        /// </summary>
        public int MemoryBus { get; private set; }

        /// <summary>
        /// Maximum Operating Size of GPU RAM
        /// </summary>
        public int MemoryBandwidth { get; private set; }

        /// <summary>
        /// Powerdelivery of GPU
        /// </summary>
        public int Tdp { get; private set; }

        /// <summary>
        /// MSRP of GPU
        /// </summary>
        public float Price { get; private set; }

        /// <summary>
        /// Createing a new GPU Entry
        /// </summary>
        /// <param name="brand">Name of Manufacturer of GPU</param>
        /// <param name="mdoel">Productname of GOU</param>
        /// <param name="cores">Corecount of GPU</param>
        /// <param name="basefreqency">Base Frequency of GPU</param>
        /// <param name="boostfrequency">Maximum Frequency of GPU</param>
        /// <param name="tflops">Powerdelivery to GPU</param>
        /// <param name="memtype">Type of memory used in GPU</param>
        /// <param name="memsize">Size of GPU RAM in GB</param>
        /// <param name="memfreq">Frequency of GPU RAM</param>
        /// <param name="membus">Connection between GPU and CPU RAM</param>
        /// <param name="membandwidth">Maximum operating size of GPU memory</param>
        /// <param name="tdp">Powerdelivery of GPU</param>
        /// <param name="price">MSRP of GPU</param>
        public GPU(string brand, string model, int cores, float basefreqency, float boostfrequency, decimal tflops,
                   string memtype, int memsize, float memfreq, int membus, int membandwidth, int tdp, float price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Cores = cores;
            this.BaseFrequency = basefreqency;
            this.BoostFrequency = boostfrequency;
            this.TeraFlops = tflops;
            this.MemoryType = memtype;
            this.MemorySize = memsize;
            this.MemoryClock = memfreq;
            this.MemoryBus = membus;
            this.MemoryBandwidth = membandwidth;
            this.Tdp = tdp;
            this.Price = price;

        }
    }
}
