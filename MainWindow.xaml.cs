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

namespace U3RandomKeegan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //creates a random number every time
            Random random = new Random();

            InitializeComponent();

            /*//pick a number in a range
            MessageBox.Show("Random grade: " + random.Next(30, 101).ToString());
            MessageBox.Show("Random grade: " + random.Next(30, 101).ToString());
            MessageBox.Show("Random grade: " + random.Next(30, 101).ToString());

            //simulate a dice role
            MessageBox.Show("Dice role: " + (random.Next(6) + 1).ToString());
            MessageBox.Show("Dice role: " + (random.Next(6) + 1).ToString());
            MessageBox.Show("Dice role: " + (random.Next(6) + 1).ToString());

            //will make the same number
            Random random = new Random(1);
            Random random2 = new Random(1);

            MessageBox.Show("Random 1: " + random.Next().ToString() + "\r\nRandom 2: " + random2.Next().ToString());
            MessageBox.Show("Random 1: " + random.Next().ToString() + "\r\nRandom 2: " + random2.Next().ToString());
            MessageBox.Show("Random 1: " + random.Next().ToString() + "\r\nRandom 2: " + random2.Next().ToString());
            MessageBox.Show("Random 1: " + random.Next().ToString() + "\r\nRandom 2: " + random2.Next().ToString()); */
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {

            Random random = new Random();

            int theCurrentRandomNumber = random.Next(1, 7);
            MessageBox.Show("Winning number: " + theCurrentRandomNumber.ToString());

            int.TryParse(txbInput.Text, out int numberGuessed);
            MessageBox.Show("Number guessed: " + numberGuessed.ToString());

            if (theCurrentRandomNumber == numberGuessed)
            {
                lblOutput.Content = "Get a lotto ticket you lucky fellow!";
            }
            else
            {
                lblOutput.Content = "Spend more money to try again";
            }
        }
    }
}
