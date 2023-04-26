using CV12;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
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
using WebApp;
using WebApp.Pages;

namespace WpfApp
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalcDTO calcDTO = new CalcDTO();
            decimal vysl = 0;
            switch (comboBox.Text)
            {
                case "+":
                    vysl = Decimal.Parse((FirstOperand.Text.ToString() + SecondOperand.Text.ToString()).ToString());
                    MessageBox.Show(vysl.ToString());
                    return;
                case "-":

                    return;
                case "*":

                    return;
                case "/":

                    return;

            }


        }

        
    }
}
