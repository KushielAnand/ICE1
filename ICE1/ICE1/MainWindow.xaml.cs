using System;
using System.Collections.Generic;
using System.IO;
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

namespace ICE1
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string filepath = "details.txt";
            List<string> lines = new List<string>();
            List<Details> detail = new List<Details>();

            lines = File.ReadAllLines(filepath).ToList();
            foreach(string line in lines)
            {
                string[] items = line.Split(',');
                Details d = new Details(items[0], items[1], items[2]);
                detail.Add(d);
            }
            

            foreach(Details d in detail)
            {
                lstDisplay.Items.Add(d);
               
            }

           
        }

        private void btnstore_Click(object sender, RoutedEventArgs e)
        {
            string[] details = 
                { 
                tbName.Text+"," +tbAge.Text + "," + tbGender.Text
            };
             File.AppendAllLines("details.txt",details);
        }
    }
}
