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

namespace TheMovies
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

        private void VidebækBtn_Click(object sender, RoutedEventArgs e)
        {
            BookingDialog bookingDialog = new BookingDialog();
            bookingDialog.ShowDialog();
            
        }

        private void ThorsmindeBtn_Click(object sender, RoutedEventArgs e)
        {
            BookingDialog bookingDialog = new BookingDialog();
            bookingDialog.ShowDialog();
        }

        private void RæhrBtn_Click(object sender, RoutedEventArgs e)
        {
            BookingDialog bookingDialog = new BookingDialog();
            bookingDialog.ShowDialog();
        }

        private void HjermBtn_Click(object sender, RoutedEventArgs e)
        {
            BookingDialog bookingDialog = new BookingDialog();
            bookingDialog.ShowDialog();
        }
    }
}
