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
using System.Windows.Shapes;

namespace EvidenceZaměstnanců
{
    /// <summary>
    /// Interakční logika pro EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public string NovyUdaje { get; private set; }

        public string NovyJmeno { get; set; }
        public string NovyPrijmeni { get; set; }
        public string NovyID { get; set; }
        public DateTime NovejDatum { get; set; }
        public EditWindow(string jmeno, string prijmeni, string ID, DateTime datum)
        {
            NovyJmeno = jmeno;
            NovyPrijmeni = prijmeni;
            NovyID = ID;
            NovejDatum = datum;

            InitializeComponent();

            NewName.Text= jmeno;
            NewSurame.Text= prijmeni;
            NewId.Text= ID;
            NewDatum.SelectedDate= datum;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NovyJmeno = NewName.Text;
            NovyPrijmeni= NewSurame.Text;
            NovyID= NewId.Text;
            NovejDatum = NewDatum.SelectedDate ?? DateTime.Now;

            NovyUdaje = NovyJmeno  + NovyPrijmeni + NovyID  + NovejDatum.ToShortDateString();

            this.DialogResult = true;
            this.Close();
        }
    }
}
