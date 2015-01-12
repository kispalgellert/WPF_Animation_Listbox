#region Usings
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
#endregion

namespace ListBoxAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ListBoxItem anItem = new ListBoxItem() { Content = "One1" };

        private ObservableCollection<ListBoxItem> ListOfItems = new ObservableCollection<ListBoxItem>();
        public MainWindow()
        {
            InitializeComponent();
            XListBox.ItemsSource = ListOfItems;
        }

        private void Add1_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem anItem = new ListBoxItem() { Content = "One1" };
            DoubleAnimation fadeAnimation = new DoubleAnimation(0, 1, new TimeSpan(0,0,0,0,500));
            DoubleAnimation growAnimation = new DoubleAnimation(0, 19.96, new TimeSpan(0, 0, 0, 0, 500));
            anItem.BeginAnimation(ListBoxItem.OpacityProperty, fadeAnimation);
            anItem.BeginAnimation(ListBoxItem.HeightProperty, growAnimation);
            ListOfItems.Add(anItem);
        }

        private void Add2_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem anItem = new ListBoxItem() { Content = "One2" };
            DoubleAnimation fadeAnimation = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 500));
            DoubleAnimation growAnimation = new DoubleAnimation(0, 19.96, new TimeSpan(0, 0, 0, 0, 500));
            anItem.BeginAnimation(ListBoxItem.OpacityProperty, fadeAnimation);
            anItem.BeginAnimation(ListBoxItem.HeightProperty, growAnimation);
            ListOfItems.Add(anItem);
        }

        private void Add3_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem anItem = new ListBoxItem() { Content = "One3" };
            DoubleAnimation fadeAnimation = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 500));
            DoubleAnimation growAnimation = new DoubleAnimation(0, 19.96, new TimeSpan(0, 0, 0, 0, 500));
            anItem.BeginAnimation(ListBoxItem.OpacityProperty, fadeAnimation);
            anItem.BeginAnimation(ListBoxItem.HeightProperty, growAnimation);
            ListOfItems.Add(anItem);
        }

        private void Add4_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem anItem = new ListBoxItem() { Content = "One4" };
            DoubleAnimation fadeAnimation = new DoubleAnimation(0, 1, new TimeSpan(0, 0, 0, 0, 2000));
            DoubleAnimation growAnimation = new DoubleAnimation(0, 19.96, new TimeSpan(0, 0, 0, 0, 500));
            anItem.BeginAnimation(ListBoxItem.OpacityProperty, fadeAnimation);
            anItem.BeginAnimation(ListBoxItem.HeightProperty, growAnimation);
            ListOfItems.Add(anItem);
        }
    }
}
