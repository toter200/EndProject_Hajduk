using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcC_PartPicker
{
    /// <summary>
    /// Saves Data for already build PCs or selve created
    /// </summary>
    public class PreBuild
    {
        /// <summary>
        /// Manufacturer of Computer
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Productname
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// Installed CPU
        /// </summary>
        public Cpu Processor { get; private set; }


        /// <summary>
        /// Installed Motherboard
        /// </summary>
        public Motherboard Mb { get; private set; }

        /// <summary>
        /// installed GPU
        /// </summary>
        public GPU GProcessor { get; private set; }

        /// <summary>
        /// Installed PSU
        /// </summary>
        public PowerSupply Psu { get; private set; }

        /// <summary>
        /// Used Case
        /// </summary>
        public Case Enclousure { get; private set; }

        /// <summary>
        /// Additional Fans(Case fans not included)
        /// </summary>
        public Fan[] ExtraFans { get; private set; }

        /// <summary>
        /// Installed Drives
        /// </summary>
        public Drive[] Internaldrives { get; private set; }

        /// <summary>
        /// Installed RAM
        /// </summary>
        public Ram RandomAccessMemory { get; private set; }

        /// <summary>
        /// Creating new Entry
        /// </summary>
        /// <param name="brand">Manufacturer of Computer</param>
        /// <param name="model">Productname</param>
        /// <param name="cpu">Installed CPU</param>
        /// <param name="mb">Installed MB</param>
        /// <param name="gpu">Installed GPU</param>
        /// <param name="psu">Installed PSU</param>
        /// <param name="caseing">Used </param>
        /// <param name="fans">Additional Fans(Case fans not included)</param>
        /// <param name="drives">Installed Drives</param>
        /// <param name="ram">Installed RAM</param>
        public PreBuild(string brand, string model, Cpu cpu, Motherboard mb, GPU gpu, PowerSupply psu, Case caseing,
                        Fan[] fans, Drive[] drives, Ram ram )
        {
            this.Brand = brand;
            this.Model = model;
            this.Processor = cpu;
            this.GProcessor = gpu;
            this.Psu = Psu;
            this.Enclousure = caseing;
            this.ExtraFans = fans;
            this.Internaldrives = drives;
            this.RandomAccessMemory = ram;
        }
    }
}
