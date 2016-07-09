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
    /// Interaction logic for WPFnewCategory.xaml
    /// </summary>
    public partial class WPFnewCategory : Window
    {
        public WPFnewCategory()
        {
            InitializeComponent();
        }

        private void btnCansel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
