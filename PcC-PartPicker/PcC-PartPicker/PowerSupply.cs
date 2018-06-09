using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcC_PartPicker
{
    /// <summary>
    /// Saves Data for a Computer Powersupply
    /// </summary>
    class PowerSupply
    {
        /// <summary>
        /// Manufacturer of PSU
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Productname of PSU
        /// </summary>
        public string  Model { get; private set; }

        /// <summary>
        /// Maximum Power output of PSU
        /// </summary>
        public int Wattage { get; private set; }

        /// <summary>
        /// Biggest compatible Pc Formfactor
        /// </summary>
        public Formfactor Size { get; private set; }

        /// <summary>
        /// Standardized Efficiency Rating of PSU
        /// </summary>
        public string Efficiency { get; private set; }

        /// <summary>
        /// Modularity of PSU
        /// </summary>
        public bool Modular { get; set; }

        /// <summary>
        /// Multi GPU capable
        /// </summary>
        public bool MultiGPU { get; private set; }

        /// <summary>
        /// Maximum amount of Sata connectors
        /// </summary>
        public int SataConnector { get; private set; }

        /// <summary>
        /// Isolation of Cable(Sleved, Rubber,...)
        /// </summary>
        public string CableType { get; private set; }

        /// <summary>
        /// MSRP of PSU
        /// </summary>
        public float Price { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brand">Manufacturer of PSU</param>
        /// <param name="model">Productname of PSU</param>
        /// <param name="wattage">Maximum Power output of PSU</param>
        /// <param name="size">Biggest compatible Pc Formfactor</param>
        /// <param name="efficiency">Standardized Efficiency Rating of PSU</param>
        /// <param name="modularity">Modularity of PSU</param>
        /// <param name="multiGPU">Multi GPU capable</param>
        /// <param name="maxsata">Maximum amount of Sata connectors</param>
        /// <param name="cabletype">Isolation of Cable(Sleved, Rubber,...)</param>
        /// <param name="price">MSRP of PSU</param>
        public PowerSupply(string brand, string model, int wattage, Formfactor size,  string efficiency, bool modularity, bool multiGPU,
                           int maxsata, string cabletype, float price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Wattage = wattage;
            this.Size = size;
            this.Efficiency = efficiency;
            this.Modular = modularity;
            this.MultiGPU = multiGPU;
            this.SataConnector = maxsata;
            this.CableType = cabletype;
            this.Price = price;
        }

        /// <summary>
        /// Adding Custom Sleved razor cables, changeing cabletype and Size
        /// </summary>
        public void CustomSleveing()
        {
            this.CableType = "Sleved";
            this.Size = Formfactor.E_ATX;
        }
    }
}
