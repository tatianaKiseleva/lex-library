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
using System.Windows.Shapes;

namespace WPFLibraryAdmin
{
    /// <summary>
    /// Interaction logic for WPFNewPublisher.xaml
    /// </summary>
    public partial class WPFNewPublisher : Window
    {
        public WPFNewPublisher()
        {
            InitializeComponent();
        }

        private void btnAddAddress_Click(object sender, RoutedEventArgs e)
        {
            WPFLibraryAdmin.AddAddress OpenAddAddress = new WPFLibraryAdmin.AddAddress();
            OpenAddAddress.ShowInTaskbar = false; // Не показывать в панели задач
            OpenAddAddress.ShowDialog();
        }

        private void btnCansel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
