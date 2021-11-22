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
namespace RocketLaunch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float launchTimeInt;
        bool invalid = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void launchBut_Click(object sender, RoutedEventArgs e)
        {
            if (launchTime.Text != "" && password.Password == "password")
            {
                try {
                    launchTimeInt = float.Parse(launchTime.Text);
                } catch 
                {
                    countdownText.Text = "Invalid Hours Input. Please try again";
                    invalid = true;
                }

                float launchDays = launchTimeInt / 24;
                float launchHours = launchDays % 1 * 24;


                if (invalid == false) { countdownText.Text = $"Launch in {((int)(launchDays)).ToString()} Days and {((int)launchHours).ToString()} Hours!"; }
                invalid = false;

            } else if (password.Password != "password" && password.Password != "") {
                countdownText.Text = "Invalid Password. Please try again.";
            }
        }
    }
}
