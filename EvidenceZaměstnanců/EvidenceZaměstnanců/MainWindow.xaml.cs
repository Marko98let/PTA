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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EvidenceZaměstnanců
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

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();

            list.Items.Add("Jmeno: " + addWindow.jmeno + ", Příjmení: " + addWindow.Prijmeni+ ", ID: " + addWindow.ID + ", Datum narození: " + addWindow.Datum.ToShortDateString());
        }

        private void EDIT_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                string záznam = list.SelectedItem.ToString();

                
                string[] PoleDoListu = záznam.Split(',');

                
                string Jmeno = PoleDoListu[0].Replace("Jmeno : ", "");
                string Prijmeni = PoleDoListu[1].Replace("Prijmeni : ", "");
                string idkID = PoleDoListu[2].Replace("ID : ", "");
                string idkdatum = PoleDoListu[3].Replace(" Datum Narození: ", "");
                DateTime datum;
                DateTime.TryParse(idkdatum, out datum);

                EditWindow editWindow = new EditWindow(Jmeno,Prijmeni,idkID, datum);
                editWindow.ShowDialog();


                if (editWindow.DialogResult == true)
                {
                    list.Items[list.SelectedIndex] = editWindow.NovyUdaje;
                }
            }
        }

        private void DEL_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                list.Items.RemoveAt

               (list.Items.IndexOf(list.SelectedItem));
            }
        }

        private void SHOW_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow showWindow = new ShowWindow();
            showWindow.ShowDialog();
        }
    }
}
