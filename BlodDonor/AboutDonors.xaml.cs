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
using System.Windows.Shapes;

namespace BlodDonor
{
    /// <summary>
    /// Interaction logic for AboutDonors.xaml
    /// </summary>
    public partial class AboutDonors : Window
    {
        
        public AboutDonors()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) // shows informations about all donors that database have
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = XXX; database = BloodDonor; integrated security = true";

            try
            {
                con.Open();
                string query = "select PersonName, PersonSurname, PersonPhone, PersonSSN, PersonBlood, PersonGender, PersonBirthday , PersonDonation from donors";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();

                SqlDataAdapter DA = new SqlDataAdapter(com);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                
                DataGrid.ItemsSource = DT.DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

    }
}
