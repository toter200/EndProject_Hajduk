using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcC_PartPicker
{
    /// <summary>
    /// Saves Data for Computer Fans
    /// </summary>
    public class Fan
    {
        /// <summary>
        /// Manufacturer of Fan
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Productname
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// Size of Fan
        /// </summary>
        public int Size { get; private set; }

        /// <summary>
        /// Noise of Fan in db
        /// </summary>
        public float Noise { get; private set; }

        /// <summary>
        /// Maximal rounds per minute at 12V
        /// </summary>
        public int Rpm { get; private set; }

        /// <summary>
        /// Price of Fan
        /// </summary>
        public float Price { get; private set; }
        /// <summary>
        /// Creating a new Entry for Fans
        /// </summary>
        /// <param name="brand">Manufacturer of Fan</param>
        /// <param name="model">Productname</param>
        /// <param name="size">Size of Fan</param>
        /// <param name="noise">Noise of Fan in db</param>
        /// <param name="rpm">Maximal rounds per minute at 12V</param>
        /// <param name="price">Price for Fan</param>
        public Fan(string brand, string model, int size, float noise, int rpm, float price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Size = size;
            this.Noise = noise;
            this.Rpm = rpm;
        }

    }
}
