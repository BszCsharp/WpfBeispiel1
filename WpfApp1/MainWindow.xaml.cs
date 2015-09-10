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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void berechnen(object sender, RoutedEventArgs e)
        {
            double akap = Convert.ToDouble(textBoxAkap.Text);
            double lzeit = Convert.ToDouble(txtBoxLaufzeit.Text);
            double zins = Convert.ToDouble(txtBoxZinssatz.Text) / 100.0;
            double ekap = akap * Math.Pow(1 + zins, lzeit);
            txtBoxEndkap.Text = ekap.ToString("C");
        }
    }
}
