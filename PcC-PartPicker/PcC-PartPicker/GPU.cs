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
        public string Brand { get; set; }

        /// <summary>
        /// PRoduct name 
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Corecount of GPU
        /// </summary>
        public int Cores { get; set; }

        /// <summary>
        /// Basic Frequency of GPU
        /// </summary>
        public int BaseFrequency { get; set; }
        
        /// <summary>
        /// Maximum Frequency of GPU
        /// </summary>
        public int BoostFrequency { get; set; }

        /// <summary>
        /// Power index based on Teraflops
        /// </summary>
        public decimal TeraFlops { get; set; }

        /// <summary>
        /// Generation and type of Memory
        /// </summary>
        public string MemoryType { get; set; }

        /// <summary>
        /// Amount of GB of RAM
        /// </summary>
        public int MemorySize { get; set; }

        /// <summary>
        /// Basic frequency
        /// </summary>
        public float MemoryClock { get; set; }

        /// <summary>
        /// Connection between CPU RAM and GPU RAM 
        /// </summary>
        public int MemoryBus { get; set; }

        /// <summary>
        /// Maximum Operating Size of GPU RAM
        /// </summary>
        public int MemoryBandwidth { get; set; }

        /// <summary>
        /// Powerdelivery of GPU
        /// </summary>
        public int Tdp { get; set; }

        /// <summary>
        /// MSRP of GPU
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="mdoel"></param>
        /// <param name="cores"></param>
        /// <param name="basefreqency"></param>
        /// <param name="boostfrequency"></param>
        /// <param name="tflops"></param>
        /// <param name="memtype"></param>
        /// <param name="memsize"></param>
        /// <param name="memfreq"></param>
        /// <param name="membus"></param>
        /// <param name="membandwidth"></param>
        /// <param name="tdp"></param>
        /// <param name="price"></param>
        public GPU(string brand, string mdoel, int cores, float basefreqency, float boostfrequency, decimal tflops,
                   string memtype, int memsize, float memfreq, int membus, int membandwidth, int tdp, float price)
        {

        }
    }
}
