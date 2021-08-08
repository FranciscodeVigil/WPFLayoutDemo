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

namespace WPFLayoutDemo
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

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new StackPanelDemo();
            window.Show();
        }

        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new WarpPanelDemo();
            window.Show();
        }

        private void btnCanvas_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CanvasDemo();
            window.Show();
        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new DockPanelDemo();
            window.Show();
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            Window window = new GridDemo();
            window.Show();
        }
    }
}
