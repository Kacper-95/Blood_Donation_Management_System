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
using System.Windows.Shapes;

namespace BlodDonor
{
    /// <summary>
    /// Interaction logic for BloodInfo.xaml
    /// </summary>
    public partial class BloodInfo : Window
    {
        public BloodInfo()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            // O+
            //First left
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RL1.Fill = new SolidColorBrush(Colors.Red);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second left
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RL2.Fill = new SolidColorBrush(Colors.Red);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third left
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RL3.Fill = new SolidColorBrush(Colors.Red);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth left
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RL4.Fill = new SolidColorBrush(Colors.Red);
            RM4.Fill = new SolidColorBrush(Colors.Red);
            
            //First right
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RR1.Fill = new SolidColorBrush(Colors.White);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second right
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RR2.Fill = new SolidColorBrush(Colors.White);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third right
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RR3.Fill = new SolidColorBrush(Colors.White);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth right
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RR4.Fill = new SolidColorBrush(Colors.White);
            RM4.Fill = new SolidColorBrush(Colors.Red);

        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            // O-

            //First left
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RL1.Fill = new SolidColorBrush(Colors.Red);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second left
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RL2.Fill = new SolidColorBrush(Colors.Red);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third left
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RL3.Fill = new SolidColorBrush(Colors.Red);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth left
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RL4.Fill = new SolidColorBrush(Colors.Red);
            RM4.Fill = new SolidColorBrush(Colors.Red);


            //First right
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RR1.Fill = new SolidColorBrush(Colors.Red);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second right
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RR2.Fill = new SolidColorBrush(Colors.Red);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third right
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RR3.Fill = new SolidColorBrush(Colors.Red);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth right
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RR4.Fill = new SolidColorBrush(Colors.Red);
            RM4.Fill = new SolidColorBrush(Colors.Red);
            
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            //A+
            //First left
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RL1.Fill = new SolidColorBrush(Colors.White);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second left
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RL2.Fill = new SolidColorBrush(Colors.Red);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third left
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RL3.Fill = new SolidColorBrush(Colors.White);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth left
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RL4.Fill = new SolidColorBrush(Colors.Red);
            RM4.Fill = new SolidColorBrush(Colors.Red);


            //First right

            RR1.Fill = new SolidColorBrush(Colors.White);

            //Second right

            RR2.Fill = new SolidColorBrush(Colors.White);

            //Third right

            RR3.Fill = new SolidColorBrush(Colors.White);

            //Forth right

            RR4.Fill = new SolidColorBrush(Colors.White);
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            //A-
            
            //First left
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RL1.Fill = new SolidColorBrush(Colors.White);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second left
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RL2.Fill = new SolidColorBrush(Colors.Red);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third left
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RL3.Fill = new SolidColorBrush(Colors.White);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth left
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RL4.Fill = new SolidColorBrush(Colors.Red);
            RM4.Fill = new SolidColorBrush(Colors.Red);


            //First right

            RR1.Fill = new SolidColorBrush(Colors.White);

            //Second right

            RR2.Fill = new SolidColorBrush(Colors.Red);

            //Third right

            RR3.Fill = new SolidColorBrush(Colors.White);

            //Forth right

            RR4.Fill = new SolidColorBrush(Colors.Red);
        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            //B+
            //First left
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RL1.Fill = new SolidColorBrush(Colors.White);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second left
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RL2.Fill = new SolidColorBrush(Colors.White);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third left
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RL3.Fill = new SolidColorBrush(Colors.Red);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth left
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RL4.Fill = new SolidColorBrush(Colors.Red);
            RM4.Fill = new SolidColorBrush(Colors.Red);


            //First right

            RR1.Fill = new SolidColorBrush(Colors.White);

            //Second right

            RR2.Fill = new SolidColorBrush(Colors.White);

            //Third right

            RR3.Fill = new SolidColorBrush(Colors.White);

            //Forth right

            RR4.Fill = new SolidColorBrush(Colors.White);
        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            //B-
            //First left
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RL1.Fill = new SolidColorBrush(Colors.White);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second left
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RL2.Fill = new SolidColorBrush(Colors.White);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third left
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RL3.Fill = new SolidColorBrush(Colors.Red);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth left
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RL4.Fill = new SolidColorBrush(Colors.Red);
            RM4.Fill = new SolidColorBrush(Colors.Red);


            //First right

            RR1.Fill = new SolidColorBrush(Colors.White);

            //Second right

            RR2.Fill = new SolidColorBrush(Colors.White);

            //Third right

            RR3.Fill = new SolidColorBrush(Colors.Red);

            //Forth right

            RR4.Fill = new SolidColorBrush(Colors.Red);
        }

        private void ComboBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            //AB-
            //First left
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RL1.Fill = new SolidColorBrush(Colors.White);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second left
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RL2.Fill = new SolidColorBrush(Colors.White);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third left
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RL3.Fill = new SolidColorBrush(Colors.White);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth left
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RL4.Fill = new SolidColorBrush(Colors.Red);
            RM4.Fill = new SolidColorBrush(Colors.Red);


            //First right

            RR1.Fill = new SolidColorBrush(Colors.White);

            //Second right

            RR2.Fill = new SolidColorBrush(Colors.White);

            //Third right

            RR3.Fill = new SolidColorBrush(Colors.White);

            //Forth right

            RR4.Fill = new SolidColorBrush(Colors.Red);
        }

        private void ComboBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            //AB+
            //First left
            RD1.Fill = new SolidColorBrush(Colors.Red);
            RL1.Fill = new SolidColorBrush(Colors.White);
            RM1.Fill = new SolidColorBrush(Colors.Red);

            //Second left
            RD2.Fill = new SolidColorBrush(Colors.Red);
            RL2.Fill = new SolidColorBrush(Colors.White);
            RM2.Fill = new SolidColorBrush(Colors.Red);

            //Third left
            RD3.Fill = new SolidColorBrush(Colors.Red);
            RL3.Fill = new SolidColorBrush(Colors.White);
            RM3.Fill = new SolidColorBrush(Colors.Red);

            //Forth left
            RD4.Fill = new SolidColorBrush(Colors.Red);
            RL4.Fill = new SolidColorBrush(Colors.Red);
            RM4.Fill = new SolidColorBrush(Colors.Red);


            //First right

            RR1.Fill = new SolidColorBrush(Colors.White);

            //Second right

            RR2.Fill = new SolidColorBrush(Colors.White);

            //Third right

            RR3.Fill = new SolidColorBrush(Colors.White);

            //Forth right

            RR4.Fill = new SolidColorBrush(Colors.White);
        }
    }
}

