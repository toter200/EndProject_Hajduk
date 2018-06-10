using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcC_PartPicker
{
    /// <summary>
    /// Saves data for Computer Case
    /// </summary>
    public class Case
    {
        /// <summary>
        /// Manufacturer of Case
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Productanme
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// Biggest supported Meinbaord size
        /// </summary>
        public Formfactor Size { get; private set; }

        /// <summary>
        /// Maximum of supported 3.5inch drives
        /// </summary>
        public int HDDBays { get; private  set; }

        /// <summary>
        /// Maximum of supported 2.5inch drives
        /// </summary>
        public int SSDBays { get; private set; }

        /// <summary>
        /// Biggest supported Radioator
        /// </summary>
        public int MaxRad { get; private set; }

        /// <summary>
        /// Minimum needed PSU size
        /// </summary>
        public Formfactor PSUSize { get; private set; }

        /// <summary>
        /// Side Panel Material (If no window = "none")
        /// </summary>
        public string SideGlas { get; private set; }

        /// <summary>
        /// All preinstalled Fans
        /// </summary>
        public Fan[] PreinstalledFans { get; private set; }

        /// <summary>
        /// Color of Case
        /// </summary>
        public string Color { get; private set; }

        /// <summary>
        /// MSRP of Case
        /// </summary>
        public float Price { get; private set; }


        /// <summary>
        /// Creating a new Case Entry
        /// </summary>
        /// <param name="brand">Manufacturer of Case</param>
        /// <param name="model">Biggest supported Meinbaord size</param>
        /// <param name="size">Biggest supported Meinbaord size</param>
        /// <param name="hdd">Maximum of supported 3.5inch drives</param>
        /// <param name="ssd">Maximum of supported 2.5inch drives</param>
        /// <param name="maxrad">Minimum needed PSU size</param>
        /// <param name="sideglas">Side Panel Material (If no window = "none")</param>
        /// <param name="fans">All preinstalled Fans</param>
        /// <param name="color">Color of Case</param>
        /// <param name="Price">MSRP of Case</param>
        public Case(string brand, string model, Formfactor size, int hdd, int ssd, int maxrad, string sideglas,
                    Fan[] fans, string color, float price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Size = size;
            this.HDDBays = hdd;
            this.SSDBays = ssd;
            this.MaxRad = maxrad;
            this.SideGlas = sideglas;
            this.PreinstalledFans = fans;
            this.Color = color;
            this.Price = price;
        }

    }
}
