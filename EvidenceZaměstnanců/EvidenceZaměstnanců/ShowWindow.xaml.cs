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

namespace EvidenceZaměstnanců
{
    /// <summary>
    /// Interakční logika pro ShowWindow.xaml
    /// </summary>
    public partial class ShowWindow : Window
    {
        public ShowWindow()
        {
            InitializeComponent();

            Udaje.Text = "Jmeno:\n" + "Prijmeni:\n" + "ID:\n" + "Datum Narození:"; 
        }

      
    }
}
