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
    /// Interaction logic for addDonor.xaml
    /// </summary>
    public partial class addDonor : Window
    {
        public string minus = "------";

        public addDonor()
        {
            InitializeComponent();
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }
 
        private void AddB_Click(object sender, RoutedEventArgs e)
        {
            string Name = nameT.Text;
            string Surname = surnameT.Text;
            string Phone = phoneT.Text;
            string SSN = peselT.Text;
            string Blood = bloodC.Text;
            string Gender = "";

            if (maleR.IsChecked == true)
                Gender = "Male";
            
            if(femaleR.IsChecked == true)
                Gender = "Female";

            string Birth = birthP.Text;
            int Donation = 0;

            if (nameT.Text == minus || nameT.Text == "")
            {
                MessageBox.Show("Fill name cell", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (surnameT.Text == minus || surnameT.Text == "")
            {
                MessageBox.Show("Fill surname cell", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (phoneT.Text == minus || phoneT.Text == "")
            {
                MessageBox.Show("Fill phone cell", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (peselT.Text == minus || peselT.Text == "")
            {
                MessageBox.Show("Fill SSN cell", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (maleR.IsChecked == false && femaleR.IsChecked == false)
            {
                MessageBox.Show("Choose gender", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (birthP.Text == "")
            {
                MessageBox.Show("Choose date of birth", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            

            else
            {
                SqlConnection con = new SqlConnection(); // procedure of adding new donor to databse
                con.ConnectionString = "data source = XXXX; database = BloodDonor; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into donors (PersonName, PersonSurname, PersonPhone, PersonSSN, PersonBlood, PersonGender, PersonBirthday, PersonDonation) values" +
                    "('" + Name + "', '" + Surname + "','" + Phone + "','" + SSN + "','" + Blood + "','" + Gender + "','" + Birth + "', '" + Donation + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                MessageBoxResult messageBox = MessageBox.Show("Donor saved", "Succes", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                if (MessageBoxResult.OK == messageBox)
                {
                    nameT.Text = "";
                    surnameT.Text = "";
                    phoneT.Text = "";
                    peselT.Text = "";
                    bloodC.Text = "";
                    maleR.IsChecked = false;
                    femaleR.IsChecked = false;
                    birthP.Text = "";
                    this.Close();

                }

            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nameT.Text = minus;
            nameT.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            surnameT.Text = minus;
            surnameT.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            phoneT.Text = minus;
            phoneT.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            peselT.Text = minus;
            peselT.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            bloodC.Text = minus;
            maleR.IsChecked = false;
            femaleR.IsChecked = false;
            birthP.Text = "";
        }

        // Focusing text boxes

        private void NameT_GotFocus(object sender, RoutedEventArgs e)
        {
            if (nameT.Text == minus)
                nameT.Text = "";
            nameT.Foreground = new SolidColorBrush(Colors.Black);
        }
       
        private void NameT_LostFocus(object sender, RoutedEventArgs e)
        {
            if (nameT.Text == "" )
                nameT.Text = minus;
            nameT.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            if (nameT.Text != "" && nameT.Text != minus)
                nameT.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void SurnameT_GotFocus(object sender, RoutedEventArgs e)
        {
            if (surnameT.Text == minus)
                surnameT.Text = "";
            surnameT.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void SurnameT_LostFocus(object sender, RoutedEventArgs e)
        {
            if (surnameT.Text == "")
                surnameT.Text = minus;
            surnameT.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            if (surnameT.Text != "" && surnameT.Text != minus)
                surnameT.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void PhoneT_GotFocus(object sender, RoutedEventArgs e)
        {
            if (phoneT.Text == minus)
                phoneT.Text = "";
            phoneT.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void PhoneT_LostFocus(object sender, RoutedEventArgs e)
        {
            if (phoneT.Text == "")
                phoneT.Text = minus;
            phoneT.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            if (phoneT.Text != "" && phoneT.Text != minus)
                phoneT.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void PeselT_GotFocus(object sender, RoutedEventArgs e)
        {
            if (peselT.Text == minus)
                peselT.Text = "";
            peselT.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void PeselT_LostFocus(object sender, RoutedEventArgs e)
        {
            if (peselT.Text == "")
                peselT.Text = minus;
            peselT.Foreground = new SolidColorBrush(Color.FromRgb(171, 171, 171));
            if (peselT.Text != "" && peselT.Text != minus)
                peselT.Foreground = new SolidColorBrush(Colors.Black);
        }

       
    }
}
