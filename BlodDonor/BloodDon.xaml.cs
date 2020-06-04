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
    /// Interaction logic for BloodDon.xaml
    /// </summary>
    public partial class BloodDon : Window
    {
        public BloodDon()
        {
            InitializeComponent();
        }

        private void SearchB_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = XXXX; database = BloodDonor; integrated security = true";

            try
            {
                con.Open();
                string query = "select * from donors where PersonName = '" + NameTB.Text+ "' and PersonSurname ='"+SurnameTB.Text+ "' or PersonSSN = '"+PeselTB.Text+"'";
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

            if (DataGrid.Items.Count == 0)
                MessageBox.Show("Something went wrog", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

            // update button
            if (DataGrid.Items.Count != 0)
                UpdateB.IsEnabled = true;
            else
                UpdateB.IsEnabled = false;
            
        }

        private void UpdateB_Click(object sender, RoutedEventArgs e)
        {
            string Donation = LitersTB.Text;
            
            SqlConnection con = new SqlConnection(); // procedure of adding new donor to databse
            con.ConnectionString = "data source = XXXX; database = BloodDonor; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update donors set PersonDonation = PersonDonation + '" + LitersTB.Text + "' where PersonName = '"+NameTB.Text+"' and PersonSurname = '"+SurnameTB.Text+ "' or PersonSSN = '"+PeselTB.Text+"' ";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            
            MessageBoxResult messageBox = MessageBox.Show("Donation added", "Succes", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                if (MessageBoxResult.OK == messageBox)
                {
                    LitersTB.Text = "";
                    this.Close();
                }
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
        
    }
}
