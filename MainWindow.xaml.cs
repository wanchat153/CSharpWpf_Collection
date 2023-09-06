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
        //Hashtable hashtable;
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();

        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //add
            sortedList.Add(textKey.Text, textName.Text);
            textKey.Clear();
            textName.Clear();
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            //remove
            sortedList.Remove(textKey.Text);
            textKey.Clear();
            textName.Clear();
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Refresh();
            //Show list
            listBox.ItemsSource = sortedList.Values;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
