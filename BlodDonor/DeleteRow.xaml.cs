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
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BlodDonor
{
    /// <summary>
    /// Interaction logic for DeleteRow.xaml
    /// </summary>
    public partial class DeleteRow : Window
    {
        public string minus = "------";
        public DeleteRow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (nameL.Text == "" || nameL.Text== minus || surameL.Text == "" ||surameL.Text == minus||peselL.Text ==  minus|| peselL.Text == "")
            {
                MessageBox.Show("Fill right", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(); // procedure of adding new donor to databse
                con.ConnectionString = "data source = XXXXX; database = BloodDonor; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select PersonName,PersonSurname, PersonSSN from donors where PersonName = '" + nameL.Text + "' and PersonSurname = '" + surameL.Text + "' and PersonSSN = '" + peselL.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                DA.Fill(DT);

                DataGrid.ItemsSource = DT.DefaultView;

                if (DataGrid.Items.Count == 0)
                {
                    MessageBox.Show("Check data");
                }
            }
            
        }

     

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            
           DialogResult result = MessageBox.Show("Do you want to delete this donor?", "Attention!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = XXXX; database = BloodDonor; integrated security = true";
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "delete from donors where PersonName = '" + nameL.Text + "' and PersonSurname = '" + surameL.Text + "' and PersonSSN = '" + peselL.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable DT = new DataTable();
                    DataGrid.ItemsSource = DT.DefaultView;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
                        
        }

        private void Dismiss_Click(object sender, RoutedEventArgs e)
        {
            nameL.Text = minus;
            nameL.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));

            surameL.Text = minus;
            surameL.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));

            peselL.Text = minus;
            peselL.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));

        }

        private void NameL_GotFocus(object sender, RoutedEventArgs e)
        {
            if (nameL.Text == minus)
            {
                nameL.Text = "";
                nameL.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void NameL_LostFocus(object sender, RoutedEventArgs e)
        {
            if (nameL.Text == "")
            {
                nameL.Text = minus;
                nameL.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            }

        }

        private void SurameL_GotFocus(object sender, RoutedEventArgs e)
        {
            if (surameL.Text == minus)
            {
                surameL.Text = "";
                surameL.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void SurameL_LostFocus(object sender, RoutedEventArgs e)
        {
            if (surameL.Text == "")
            {
                surameL.Text = minus;
                surameL.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            }
        }

        private void PeselL_GotFocus(object sender, RoutedEventArgs e)
        {
            if (peselL.Text == minus)
            {
                peselL.Text = "";
                peselL.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void PeselL_LostFocus(object sender, RoutedEventArgs e)
        {
            if (peselL.Text == "")
            {
                peselL.Text = minus;
                peselL.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            }
        }

      
    }
}
