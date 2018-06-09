using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcC_PartPicker
{
    enum Formfactor { E_ATX, ATX, Mini_ATX, Micro_ATX, ITX }

    /// <summary>
    /// Saves Data for a Computer Motherboard
    /// </summary>
    class Motherboard
    {
        /// <summary>
        /// Name of Manufacturer of MB
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Product name of MB
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// Compatible CPU Socket
        /// </summary>
        public string Socket { get; private set; }

        /// <summary>
        /// standardized Size of MB (E_ATX, ATX, Mini_ATX, Micro_ATX, ITX)
        /// </summary>
        public Formfactor Size { get; private set; }

        /// <summary>
        /// Maximum of supported Memory
        /// </summary>
        public string Memorysupport { get; private set; }

        /// <summary>
        /// Amount of M.2 Slots on MB
        /// </summary>
        public int M_2Slots { get; private set; }

        /// <summary>
        /// Amount of Sata POrts on MB
        /// </summary>
        public int SataPorts { get; private set; }

        /// <summary>
        /// Model of LAN Module
        /// </summary>
        public string LanModule { get; private set; }

        /// <summary>
        /// Model of Sound Module
        /// </summary>
        public string SoundModule { get; private set; }

        /// <summary>
        /// Amount of USB 3.1 Ports
        /// </summary>
        public int Usb3_1Ports { get; private set; }

        /// <summary>
        /// Amount of USB 2.0 Ports
        /// </summary>
        public int Usb2Ports { get; private set; }

        /// <summary>
        /// Amount of all Fan Headers
        /// </summary>
        public int FanHeader { get; private set; }

        /// <summary>
        /// Supported Lightningcontoll Software 
        /// </summary>
        public string LightningSoution { get; private set; }

        /// <summary>
        /// Price for Product
        /// </summary>
        public float Price { get; private set; }

        /// <summary>
        /// Creating a new Motherboard entry
        /// </summary>
        /// <param name="brand">Name of Manufacturer of MB</param>
        /// <param name="model">product name of MB</param>
        /// <param name="socket">Compatible CPU Socket</param>
        /// <param name="size">standardized Size of MB (E_ATX, ATX, Mini_ATX, Micro_ATX, ITX)</param>
        /// <param name="memsup">Maximum of supported Memory</param>
        /// <param name="m_2Slots">Amount of M.2 Slots on MB</param>
        /// <param name="sataPorts">Amount of Sata POrts on MB</param>
        /// <param name="lanModule">Model of LAN Module</param>
        /// <param name="soundModule">Model of Sound Module</param>
        /// <param name="usb3">Amount of USB 3.1 Ports</param>
        /// <param name="usb2">Amount of USB 2.0 Ports</param>
        /// <param name="fanHeader">Amount of all Fan Headers</param>
        /// <param name="rgb">Supported Lightningcontoll Software</param>
        /// <param name="price">Price for Product</param>
        public Motherboard(string brand, string model, string socket, Formfactor size, string memsup, int m_2Slots, int sataPorts,
                           string lanModule, string soundModule, int usb3, int usb2, int fanHeader, string rgb, float price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Socket = socket;
            this.Size = size;
            this.Memorysupport = memsup;
            this.M_2Slots = m_2Slots;
            this.SataPorts = sataPorts;
            this.LanModule = lanModule;
            this.SoundModule = soundModule;
            this.Usb3_1Ports = usb3;
            this.Usb2Ports = usb2;
            this.FanHeader = fanHeader;
            this.LightningSoution = rgb;
        }
    }
}
