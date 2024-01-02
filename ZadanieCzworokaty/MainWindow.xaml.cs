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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZadanieCzworokaty
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y;
            if (double.TryParse(sideA.Text, out x) && double.TryParse(sideB.Text, out y))
            {
                 x = double.Parse(sideA.Text);
                y = double.Parse(sideB.Text);
                if (x <= 0 || y <= 0) MessageBox.Show("Szerokość i wyskość muszą być liczbami dodatnimi");
            if (x == y)
            {
               
                obraz.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri("/rect.png", UriKind.Relative));
                    figure.Text = "To jest kwadrat";
             }
            else
                {
                    obraz.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri("/rect1.png", UriKind.Relative));
                    figure.Text = "To jest prosotkąt";
                }
                ComboBoxItem selectedItem = (ComboBoxItem)myList.SelectedItem;
                string selectedEl = selectedItem.Content.ToString();
                if (selectedEl == "Obwód")
                {
                    double o = 2 * x + 2 * y;
                    result.Text = "Obwód wynosi: " + o.ToString();

                }
                if (selectedEl == "Pole")
                {
                    double p = x * y;
                    result.Text = "Pole wynosi: " + p.ToString();

                }
                if (selectedEl == "Przekątna")
                {
                    double pp = Math.Sqrt(x*x + y*y);
                    result.Text = "Obwód wynosi: " + pp.ToString();

                }

            }
        }
    }
}
