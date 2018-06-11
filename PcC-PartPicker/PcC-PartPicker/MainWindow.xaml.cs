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
        string connectionString;

        private List<Fan> fans = new List<Fan>();

        public ObservableCollection<object> allParts;


        private ObservableCollection<object> compatibleParts;
        private ObservableCollection<object> wishlist;
 
        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["PcC_PartPicker.Properties.Settings.PartsConnectionString"].ConnectionString;
            SQLDataPicker dataPicker = new SQLDataPicker(connectionString);
            allParts = new ObservableCollection<object>();
            wishlist = new ObservableCollection<object>();
            compatibleParts = new ObservableCollection<object>();

            foreach (var item in dataPicker.GetAllCPU())
            {
                allParts.Add(item);
                compatibleParts.Add(item);
            }
            foreach (var item in dataPicker.GetAllGPU())
            {
                allParts.Add(item);
                compatibleParts.Add(item);
            }
            foreach (var item in dataPicker.GetAllMB())
            {
                allParts.Add(item);
                compatibleParts.Add(item);
            }
            foreach (var item in dataPicker.GetAllFAN())
            {
                allParts.Add(item);
                fans.Add(item);
                compatibleParts.Add(item);
            }
            foreach (var item in dataPicker.GetAllCase(fans))
            {
                allParts.Add(item);
                compatibleParts.Add(item);
            }
            Items_LB.ItemsSource = allParts;
            foreach (var item in dataPicker.GetAllRam())
            {
                allParts.Add(item);
                compatibleParts.Add(item);
            }
            foreach (var item in dataPicker.GetAllDrive())
            {
                allParts.Add(item);
                compatibleParts.Add(item);
            }
            foreach (var item in dataPicker.GetAllPowerSupply())
            {
                allParts.Add(item);
                compatibleParts.Add(item);
            }
            WishList_LB.ItemsSource = wishlist;
            Items_LB.ItemsSource = compatibleParts;
        }



        private void Items_LB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ItemAttributes_DG.ItemsSource = new object[] { (object)Items_LB.SelectedItem };
        }


        private void AddToList_Btn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in compatibleParts)
            {
                if (item == Items_LB.SelectedItem)
                {
                    compatibleParts.Remove(item);
                    break;
                }
            }
        }

        
    }
}
