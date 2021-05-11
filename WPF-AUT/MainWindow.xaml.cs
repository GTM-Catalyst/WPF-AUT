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

namespace WPF_AUT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DateText.Text = DateTime.Now.ToShortDateString();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            decimal total = Convert.ToDecimal(FirstNumber.Text) + Convert.ToDecimal(SecondNumber.Text);
            ResultsBlock.Text = total.ToString();

        }

        private void Substract_Button_Click(object sender, RoutedEventArgs e)
        {
            decimal total = Convert.ToDecimal(FirstNumber.Text) - Convert.ToDecimal(SecondNumber.Text);
            ResultsBlock.Text = total.ToString();
        }

        private void Greeting_Action(object sender, RoutedEventArgs e)
        {
            ResultsBlock.Text = "Hello, " + Username.Text;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SecondNumber.IsEnabled = !SecondNumber.IsEnabled;
        }
    }
}
