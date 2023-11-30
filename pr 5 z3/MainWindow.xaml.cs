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

namespace pr_5_z3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(priceTextBox.Text, out double pricePerKg))
            {

                resultTextBlock.Text = "";


                for (int kg = 1; kg <= 10; kg++)
                {
                    double totalCost = pricePerKg * kg;
                    resultTextBlock.Text += $"{kg} кг: {totalCost:C}\n";
                }
            }
        }
    }
}



       