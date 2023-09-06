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
        //ArrayList arrayList;
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //add
            hashtable.Add(textKey.Text, textName.Text);
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            //remove
            hashtable.Remove(textKey.Text);
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            //hashtable key name
            ICollection collection = hashtable.Keys;
            foreach (var key in collection)
            {
                //Show All
                MessageBox.Show(hashtable[key].ToString());
            }

            //Count data
            MessageBox.Show("Count: "+ hashtable.Count.ToString());

        }
    }
}
