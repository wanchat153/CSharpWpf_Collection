using System;
using System.Collections;
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

namespace CSharpWpf_Collection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            //Add data
            arrayList.Add(10);
            arrayList.Add(15);
            arrayList.Add(16);
            arrayList.Add(10);
            arrayList.Add(18);

            //remove (10)Object
            arrayList.Remove(10);
            //remove (2)index
            arrayList.RemoveAt(2);
            //show low to high
            arrayList.Sort();

            foreach (var item in arrayList)
            {
                //Show All
                MessageBox.Show(item.ToString());
            }

            //Count data
            MessageBox.Show("Count: "+ arrayList.Count.ToString());

        }
    }
}
