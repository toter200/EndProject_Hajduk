using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcC_PartPicker
{
    /// <summary>
    /// Saves Data for Computer 
    /// </summary>
    public class Ram
    {
        /// <summary>
        /// Manufacturer of RAM
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Productname
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// capacity of RAM in GB
        /// </summary>
        public int Size { get; private set; }

        /// <summary>
        /// Base Frequecy of RAM
        /// </summary>
        public int Speed { get; private set; }

        /// <summary>
        /// Amount of sticks
        /// </summary>
        public int Module { get; private set; }

        /// <summary>
        /// Price of RAM
        /// </summary>
        public double Price { get; private set; }

        /// <summary>
        /// Creating a new Entry
        /// </summary>
        /// <param name="brand">Manufacturer of RAM</param>
        /// <param name="model">Productname</param>
        /// <param name="size">capacity of RAM in GB</param>
        /// <param name="speed">Base Frequecy of RAM</param>
        /// <param name="module">Amount of sticks</param>
        /// <param name="price">Price of RAM</param>
        public Ram(string brand, string model, int size, int speed, int module, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Size = size;
            this.Speed = speed;
            this.Module = module;
            this.Price = price;
        }

        public override string ToString()
        {
            return Brand + " " + Model + " " + Size + "GB";
        }
    }
}
