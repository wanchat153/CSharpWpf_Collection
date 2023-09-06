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
            //Add data
            arrayList.Add(textName.Text);
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            //remove ()Object
            arrayList.Remove(textName.Text);
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {

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
