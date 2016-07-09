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
    /// Interaction logic for WPFMedia.xaml
    /// </summary>
    public partial class WPFMedia : Window
    {
        NyLibraryDBDataContext DataBase = new NyLibraryDBDataContext();
        public WPFMedia()
        {
            InitializeComponent();

            //format
            var format = from SelectFormat in DataBase.Formats
                         select new { SelFormat = SelectFormat.Name, FormatID = SelectFormat.FormatID };
            this.cbxFormat.ItemsSource = format;

            cbxFormat.DisplayMemberPath = "SelFormat";

            cbxFormat.SelectedValuePath = "FormatID";

            //publisher
            var publisher = from SelectPublisher in DataBase.Publishers
                          select new { SelPublisher = SelectPublisher.Name, PublisherID = SelectPublisher.PublisherID };
            this.cbxPublisher.ItemsSource = publisher;

            cbxPublisher.DisplayMemberPath = "SelPublisher";

            cbxPublisher.SelectedValuePath = "PublisherID";

            //author
            var author = from SelectAuthor in DataBase.Persons
                         join m in DataBase.MediaAuthors on SelectAuthor.PersonID equals m.PersonID
                         select new { SelAutor = SelectAuthor.FirstName + " " + SelectAuthor.LastName, PersonID = m.PersonID };
                            
            this.cbxAuthor.ItemsSource = author;

            cbxAuthor.DisplayMemberPath = "SelAutor";

            cbxAuthor.SelectedValuePath = "PersonID";

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
    

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnNewCategory_Click(object sender, RoutedEventArgs e)
        {
            WPFLibraryAdmin.WPFnewCategory openWSeach = new WPFLibraryAdmin.WPFnewCategory();
            openWSeach.ShowInTaskbar = false; // Не показывать в панели задач
            openWSeach.ShowDialog();
        }

        private void btnNewAuthor_Click(object sender, RoutedEventArgs e)
        {

            WPFLibraryAdmin.NewAuthor addNewAuthor =new WPFLibraryAdmin.NewAuthor();
            addNewAuthor.ShowInTaskbar = false; // Не показывать в панели задач
            addNewAuthor.ShowDialog();
        
    }

        private void btnNewPublisher_Click(object sender, RoutedEventArgs e)
        {
            WPFLibraryAdmin.WPFNewPublisher addNewPublisher = new WPFLibraryAdmin.WPFNewPublisher();
            addNewPublisher.ShowInTaskbar = false;
            addNewPublisher.ShowDialog();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Window ownedWindow = new Window();
            ownedWindow.Owner = this;
            ownedWindow.ShowDialog();
            string Format=cbxFormat.SelectedValue.ToString();
            string Category=cbxCategory.SelectedValue.ToString();
            
        }
    }
}
