using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Collections.ObjectModel;

namespace PcC_PartPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        string connectionString;

        public ObservableCollection<Cpu> cpuList;
        public ObservableCollection<Motherboard> motherboardList;
        public ObservableCollection<GPU> gpulist;
        public ObservableCollection<PowerSupply> psuList;

        public MainWindow()
        {
            InitializeComponent();
            cpuList = new ObservableCollection<Cpu>();
            connectionString = ConfigurationManager.ConnectionStrings["PcC_PartPicker.Properties.Settings.PartsConnectionString"].ConnectionString;
            PopulateCPU();
            Items_LB.ItemsSource = cpuList;
        }

         private void PopulateCPU()
        {
            /*using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Brand FROM CPU", connection))
            {
                DataTable cputable = new DataTable();
                adapter.Fill(cputable);


                foreach (var item in cputable.AsDataView())
                {
                    Items_LB.ItemsSource =  item;
                }

                //ItemAttributes_DG.ItemsSource = cputable.AsDataView();

            }*/

            connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Select * FROM CPU");
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
                    cpuList.Add(cpu);
                }
                

            }
            connection.Close();
            /*SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();

            string Brand = command.ExecuteScalar("dwasdAWd");
            string brand = (string)new SqlCommand("Select Brand FROM CPU").ExecuteScalar();
            string model = (string)new SqlCommand("Select Model FROM CPU").ExecuteScalar();
            connection.Close();

            */
        }

        private void Items_LB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ItemAttributes_DG.ItemsSource = new Cpu[] { (Cpu)Items_LB.SelectedItem };
        }
    }
}
