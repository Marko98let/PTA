using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interakční logika pro AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {  
        public string jmeno { get; set; }

        public string Prijmeni { get; set; }

        public string ID { get; set; }

        public DateTime Datum { get; set; }

     

        public AddWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            jmeno = Name.Text;
            Prijmeni = Surname.Text;
            ID = Id.Text;

            Datum = calendar.SelectedDate ?? DateTime.Today;
            this.Close();
        }
    }
}
