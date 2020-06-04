using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace BlodDonor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void MiAdd_Click(object sender, RoutedEventArgs e)
        {
            addDonor addDonor = new addDonor();
            addDonor.Show();
            this.Hide();
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MiDoantion_Click(object sender, RoutedEventArgs e)
        {
            BloodDon bloodDon = new BloodDon();
            this.Hide();
            bloodDon.Show();
        }

        private void MiDonor_Click(object sender, RoutedEventArgs e)
        {
            AboutDonors aboutDonors = new AboutDonors();
            aboutDonors.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) // Shows how many donors system have
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = XXXX; database = BloodDonor; integrated security = true";

            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM donors";
                string query2 = "SELECT SUM(PersonDonation) FROM donors";
                SqlCommand com = new SqlCommand(query, con);
                SqlCommand com2 = new SqlCommand(query2, con);
                var sum1 =com.ExecuteScalar();
                var sum = com2.ExecuteScalar();
                donatedBloodL.Content = sum.ToString();
                donorsNumberL.Content = sum1.ToString();
                if (sum1.ToString() == "0")
                    donatedBloodL.Content = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void MiDelete_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DeleteRow deleteRow = new DeleteRow();
            deleteRow.Show();
        }

        private void MiBlood_Click(object sender, RoutedEventArgs e)
        {
            BloodInfo bloodInfo = new BloodInfo();
            bloodInfo.Show();
        }
    }
}
