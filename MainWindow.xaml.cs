using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace ProgLab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateBrandComboBox();
            PopulateMemoryComboBox();
            lbDisplay.ItemsSource = Data.Users;
        }
        void PopulateBrandComboBox()
        {

            cbBrand.Items.Add("Ipod");
            cbBrand.Items.Add("Zune");
            cbBrand.SelectedIndex = 0;
        }
        void PopulateMemoryComboBox()
        {
            cbMemory.Items.Add(128.ToString());
            cbMemory.Items.Add(64.ToString());
            cbMemory.Items.Add(32.ToString());
            cbMemory.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string model = txtModel.Text;
            string memory = cbMemory.SelectedIndex.ToString();
            string brand = cbBrand.SelectedIndex.ToString();
            Data.AddUserToCollection(new User(firstName, lastName, model, memory, brand));
        }

        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            DeleteSongs();
        }
    }
}
