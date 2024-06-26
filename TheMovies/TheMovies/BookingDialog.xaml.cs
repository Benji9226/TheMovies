﻿using System;
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

namespace TheMovies
{
    /// <summary>
    /// Interaction logic for BookingDialog.xaml
    /// </summary>
    public partial class BookingDialog : Window
    {
        GuestDetails guestDetails = new GuestDetails();
        public BookingDialog()
        {
            InitializeComponent();
        }

        private void GoToGuestDetailBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            guestDetails.ShowDialog();
        }
    }
}
