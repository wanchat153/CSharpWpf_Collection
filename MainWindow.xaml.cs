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
        //SortedList sortedList;
        //Stack stack; //Last In First Out
        Queue queue; //First In First Out
        public MainWindow()
        {
            InitializeComponent();
            queue = new Queue();

        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            //add
            queue.Enqueue(textName.Text);
            textName.Clear();

            listBox.Items.Refresh();
            listBox.ItemsSource = queue;
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            //remove
            queue.Dequeue();
            textName.Clear();

            listBox.Items.Refresh();
            listBox.ItemsSource = queue;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
