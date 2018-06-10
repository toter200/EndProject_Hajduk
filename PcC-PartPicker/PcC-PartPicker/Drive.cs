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
    public class Drive
    {
        /// <summary>
        /// Manufacturer name
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Productname
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// Type of Drive (true = SSD / false = HDD)
        /// </summary>
        public bool Ssd { get; private set; }

        /// <summary>
        /// Connection interface (Sata / NVME)
        /// </summary>
        public string ConnectionType { get; private set; }

        /// <summary>
        /// Size of Drive in GB
        /// </summary>
        public int Size { get; private set; }

        /// <summary>
        /// Sequential Readspeed 
        /// </summary>
        public int ReadSpeed { get; private set; }

        /// <summary>
        /// Sequentia Writespeed
        /// </summary>
        public int WriteSpead { get; private set; }

        /// <summary>
        /// Price of Drive
        /// </summary>
        public float Price { get; private set; }

        /// <summary>
        /// Creating a new Entry for Drive
        /// </summary>
        /// <param name="brand">Manufacturer name</param>
        /// <param name="model">Productname</param>
        /// <param name="ssd">Type of Drive (true = SSD / false = HDD)</param>
        /// <param name="connection">Connection interface (Sata / NVME)</param>
        /// <param name="size">Size of Drive in GB</param>
        /// <param name="read">Sequential Readspeed </param>
        /// <param name="write">Sequentia Writespeed</param>
        /// <param name="price">Price of Drive</param>
        public Drive(string brand, string model, bool ssd, string connection, int size, int read, int write, float price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Ssd = ssd;
            this.ConnectionType = connection;
            this.Size = size;
            this.ReadSpeed = read;
            this.WriteSpead = write;
            this.Price = price;
        }
    }
}
