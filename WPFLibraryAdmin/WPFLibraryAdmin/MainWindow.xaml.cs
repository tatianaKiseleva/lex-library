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
using System.Data.Linq;

namespace WPFLibraryAdmin
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

        private void btnSeachMedia_Click(object sender, RoutedEventArgs e)
        {
            WPFLibraryAdmin.Window1 openWSeach = new WPFLibraryAdmin.Window1();
            openWSeach.ShowInTaskbar = false; // Не показывать в панели задач
            openWSeach.ShowDialog();
           
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            WPFLibraryAdmin.WPFLogIn openWSeach = new WPFLibraryAdmin.WPFLogIn();
            openWSeach.ShowInTaskbar = false; // Не показывать в панели задач
            openWSeach.ShowDialog();
        }

        private void btnNewMedia_Click(object sender, RoutedEventArgs e)
        {
            WPFLibraryAdmin.WPFMedia openWSeach = new WPFLibraryAdmin.WPFMedia();
            openWSeach.ShowInTaskbar = false; // Не показывать в панели задач
            openWSeach.ShowDialog();
        }
    }
}
