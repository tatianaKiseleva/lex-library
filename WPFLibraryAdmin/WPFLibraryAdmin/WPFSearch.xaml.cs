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
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Linq;
using System.Collections;
using System.Data.SqlClient;


namespace WPFLibraryAdmin
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        NyLibraryDBDataContext DataBase = new NyLibraryDBDataContext();
        public Window1()
        {
            InitializeComponent();
           
       //format
            var format = from SelectFormat in DataBase.Formats
                         select new { SelFormat = SelectFormat.Name, FormatID = SelectFormat.FormatID };
           this.cbxFormat.ItemsSource = format;

            cbxFormat.DisplayMemberPath = "SelFormat";

            cbxFormat.SelectedValuePath = "FormatID";
            
            
            //library
            var library = from SelectLibrary in DataBase.Libraries
                         select new { SelLibrary = SelectLibrary.Name, LibraryID = SelectLibrary.LibraryID };
            this.cbxLibrary.ItemsSource = library;

            cbxLibrary.DisplayMemberPath = "SelLibrary";

            cbxLibrary.SelectedValuePath = "LibraryID";

            //category
            var category = from SelectCategory in DataBase.Categories
                          select new { SelCategory = SelectCategory.Name, CategoryID = SelectCategory.CategoryID };
            this.cbxCategory.ItemsSource = category;

            cbxCategory.DisplayMemberPath = "SelCategory";

            cbxCategory.SelectedValuePath = "CategoryID";

            //language
            var language = from SelectLanguage in DataBase.Languages
                           select new { SelLanguage = SelectLanguage.Name, LanguageID = SelectLanguage.LanguageID };
            this.cbxLanguage.ItemsSource = language;

            cbxLanguage.DisplayMemberPath = "SelLanguage";

            cbxLanguage.SelectedValuePath = "LanguageID";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
      
            this.Close();
        }

        private void cbxFormat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selformat = (int)cbxFormat.SelectedValue;
            var selectFormat = from Mediatbl in DataBase.Medias
                               where Mediatbl.FormatID == selformat
                               select Mediatbl;
            this.listBox.ItemsSource = selectFormat;
            


            //foreach (var f in selectFormat)
            //{
            //    listBox.Items.Add(f.Title,f.MediaAuthors,f.MediaLibraries,f.Publisher);
            //}
        }

        private void cbxLibrary_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
