using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Collections.ObjectModel;

namespace PcC_PartPicker
{
    /// <summary>
    /// Collects Data from the Parts DataBase
    /// </summary>
    public class SQLDataPicker
    {
        /// <summary>
        /// String to indicate connection to Database
        /// </summary>
        private string connectionString;

        public SQLDataPicker(string conn)
        {
            connectionString = conn;
        }

        /// <summary>
        /// Collecting all CPU data from the DB
        /// </summary>
        public List<Cpu> GetAllCPU()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * FROM CPU");

            List<Cpu> cpus = new List<Cpu>();

            command.Connection = connection;
            connection.Open();
            using (connection)
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; i < 1; i++)
                {
                    reader.Read();
                    string brand = reader.GetString(1);
                    string model = reader.GetString(2);
                    int cores = reader.GetInt32(3);
                    int threads = reader.GetInt32(4);
                    double baseclock = reader.GetDouble(5);
                    double boostclock = reader.GetDouble(6);
                    string socket = reader.GetString(7);
                    int tdp = reader.GetInt32(8);
                    int l3chache = reader.GetInt32(9);
                    int maxmem = reader.GetInt32(10);
                    bool unlocked;
                    if (reader.GetSqlBoolean(11) == true)
                    {
                        unlocked = true;
                    }
                    else
                    {
                        unlocked = false;
                    }
                    double price = reader.GetDouble(12);
                    Cpu cpu = new Cpu(brand, model, cores, threads, baseclock, boostclock, socket, tdp, l3chache, maxmem, unlocked, price);
                    cpus.Add(cpu);
                }
                    
            }
            connection.Close();
            return cpus;
        }

        public List<GPU> GetAllGPU()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * FROM GPU");

            List<GPU> gpus = new List<GPU>();

            command.Connection = connection;
            connection.Open();
            using (connection)
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; i < 1; i++)
                {
                    reader.Read();
                    string brand = reader.GetString(1);
                    string model = reader.GetString(2);
                    int cores = reader.GetInt32(3);
                    double baseClock = reader.GetDouble(4);
                    double boostClock = reader.GetDouble(5);
                    double tFlops = reader.GetDouble(6);
                    string memtype = reader.GetString(7);
                    int memSize = reader.GetInt32(8);
                    double memClock = reader.GetDouble(9);
                    int memBus = reader.GetInt32(10);
                    int membandwitch = reader.GetInt32(11);
                    int tdp = reader.GetInt32(12);
                    double price = reader.GetDouble(13);
                    GPU gpu = new GPU(brand, model, cores, baseClock, boostClock, tFlops, memtype, memSize, memClock, memBus, membandwitch, tdp, price);
                    gpus.Add(gpu);
                }

            }
            connection.Close();
            return gpus;
        }

        public List<Motherboard> GetAllMB()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * FROM MotherBoard");

            List<Motherboard> mbs = new List<Motherboard>();

            command.Connection = connection;
            connection.Open();
            using (connection)
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; i < 1; i++)
                {
                    reader.Read();
                    string brand = reader.GetString(1);
                    string model = reader.GetString(2);
                    string socket = reader.GetString(3);
                    Formfactor size = Formfactor.ATX;
                    switch (reader.GetString(4))
                    {
                        case "ATX":
                            size = Formfactor.ATX;
                            break;
                        case "E-ATX":
                            size = Formfactor.E_ATX;
                            break;
                        case "Mini-ATX":
                            size = Formfactor.Mini_ATX;
                            break;
                        case "Micro-ATX":
                            size = Formfactor.Micro_ATX;
                            break;
                        case "ITX":
                            size = Formfactor.ITX;
                            break;

                    }
                    int memsup = reader.GetInt32(5);
                    int m2_support = reader.GetInt32(6);
                    int sataPorts = reader.GetInt32(7);
                    string lanModule = reader.GetString(8);
                    string soundModule = reader.GetString(9);
                    int usb3 = reader.GetInt32(10);
                    int usb2 = reader.GetInt32(11);
                    int fanheader = reader.GetInt32(12);
                    string rgb = reader.GetString(13);
                    double price = reader.GetDouble(14);
                    Motherboard mb = new Motherboard(brand, model, socket, size, memsup, m2_support, sataPorts, lanModule, soundModule, usb3, usb2, fanheader, rgb, price);
                    mbs.Add(mb);
                }

            }
            connection.Close();
            return mbs;
        }
        public List<Fan> GetAllFAN()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * FROM FAN");

            List<Fan> fans = new List<Fan>();

            command.Connection = connection;
            connection.Open();
            using (connection)
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; i < 1; i++)
                {
                    reader.Read();
                    int id = reader.GetInt32(0);
                    string brand = reader.GetString(1);
                    string model = reader.GetString(2);
                    int size = reader.GetInt32(3);

                    int noise = reader.GetInt32(4);
                    int rpm = reader.GetInt32(5);
                    double price = reader.GetDouble(6);

                    Fan fan = new Fan(id, brand, model, size, noise, rpm, price);
                    fans.Add(fan);
                }

            }
            connection.Close();
            return fans;
        }

        public List<Case> GetAllCase(List<Fan> fans)
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * FROM _CASE");

            List<Fan> includedfans = new List<Fan>();
            List<Case> cases = new List<Case>();

            command.Connection = connection;
            connection.Open();
            using (connection)
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; i < 1; i++)
                {
                    reader.Read();
                    string brand = reader.GetString(1);
                    string model = reader.GetString(2);
                    Formfactor size = Formfactor.ATX;
                    switch (reader.GetString(3))
                    {
                        case "ATX":
                            size = Formfactor.ATX;
                            break;
                        case "E-ATX":
                            size = Formfactor.E_ATX;
                            break;
                        case "Mini-ATX":
                            size = Formfactor.Mini_ATX;
                            break;
                        case "Micro-ATX":
                            size = Formfactor.Micro_ATX;
                            break;
                        case "ITX":
                            size = Formfactor.ITX;
                            break;

                    }
                    int hdd = reader.GetInt32(4);
                    int ssd = reader.GetInt32(5);
                    int maxrad = reader.GetInt32(6);
                    string sideglass = reader.GetString(7);
                    foreach (var item in reader.GetString(8).Split(','))
                    {
                        foreach (var fan in fans)
                        {
                            if (fan.ID == int.Parse(item))
                            {
                                includedfans.Add(fan);
                            }
                        }
                    }

                    string color = reader.GetString(9);
                    double price = reader.GetDouble(10);
                    Case _case = new Case(brand, model, size, hdd, ssd, maxrad, sideglass, includedfans, color, price);
                    cases.Add(_case);
                }

            }
            connection.Close();
            return cases;
        }

        public List<Ram> GetAllRam()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * FROM RAM");

            List<Ram> rams = new List<Ram>();

            command.Connection = connection;
            connection.Open();
            using (connection)
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; i < 1; i++)
                {
                    reader.Read();
                    string brand = reader.GetString(1);
                    string model = reader.GetString(2);
                    int size = reader.GetInt32(3);
                    int speed = reader.GetInt32(4);
                    int module = reader.GetInt32(5);
                    double price = reader.GetDouble(6);

                    Ram ram = new Ram(brand, model, size, speed, module, price);
                    rams.Add(ram);
                }

            }
            connection.Close();
            return rams;
        }
        public List<Drive> GetAllDrive()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * FROM DRIVE");

            List<Drive> drives = new List<Drive>();

            command.Connection = connection;
            connection.Open();
            using (connection)
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; i < 1; i++)
                {
                    reader.Read();
                    string brand = reader.GetString(1);
                    string model = reader.GetString(2);
                    bool ssd = false;
                    if (reader.GetSqlBoolean(3) == true)
                    {
                        ssd = true;
                    }
                    string conn = reader.GetString(4);
                    int size = reader.GetInt32(5);
                    int read = reader.GetInt32(6);
                    int write = reader.GetInt32(7);
                    double price = reader.GetDouble(8);

                    Drive drive = new Drive(brand, model, ssd, conn, size, read, write, price);
                    drives.Add(drive);
                }

            }
            connection.Close();
            return drives;
        }

        public List<PowerSupply> GetAllPowerSupply()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * FROM PowerSupply");

            List<PowerSupply> powersupplies = new List<PowerSupply>();

            command.Connection = connection;
            connection.Open();
            using (connection)
            using (var reader = command.ExecuteReader())
            {
                for (int i = 0; i < 1; i++)
                {
                    reader.Read();
                    string brand = reader.GetString(1);
                    string model = reader.GetString(2);
                    int wattage = reader.GetInt32(3);
                    Formfactor size = Formfactor.ATX;
                    switch (reader.GetString(4))
                    {
                        case "E-ATX":
                            size = Formfactor.E_ATX;
                            break;
                        case "Mini-ATX":
                            size = Formfactor.Mini_ATX;
                            break;
                        case "Micro-ATX":
                            size = Formfactor.Micro_ATX;
                            break;
                        case "ITX":
                            size = Formfactor.ITX;
                            break;
                    }
                    string effefficiency = reader.GetString(5);
                    bool modularity = false;
                    if (reader.GetSqlBoolean(6) == true)
                    {
                        modularity = true;
                    }
                    bool multigpu = false;
                    if (reader.GetSqlBoolean(7) == true)
                    {
                        multigpu = true;
                    }
                    int maxsata = reader.GetInt32(8);
                    string cabletype = reader.GetString(9);
                    double price = reader.GetDouble(10);



                    PowerSupply powersupply = new PowerSupply(brand, model, wattage, size,effefficiency, modularity, multigpu, maxsata, cabletype, price);
                    powersupplies.Add(powersupply);
                }

            }
            connection.Close();
            return powersupplies;
        }

    }
}
