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
    /// Interaction logic for SaveNewMedia.xaml
    /// </summary>
    /// 


    public partial class SaveNewMedia : Window
    {
        internal string formatName = null;
        internal int    formatIdx = -1;

        internal string catName = null;
        internal int catIdx = -1;

        internal string langName = null;
        internal int langIdx = -1;

        internal string publName = null;
        internal int publIdx = -1;

        internal string title = null;
        internal string year = null;
        internal string isbn = null;

        public SaveNewMedia()
        {
            InitializeComponent();
        }

        public void UpdateLabels()
        {
            this.lblFormatValue.Content = formatName;
            this.lblCatVal.Content = catName;
            this.lbllangVal.Content = langName;
            this.lblpubl.Content = publName;
            this.lbltit.Content = title;
            this.lblyear.Content = year;
            this.lblisbn.Content = isbn;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            NyLibraryDBDataContext DataBase = new NyLibraryDBDataContext();
            var newMedia = new Media();
            if((formatIdx != -1)&&(formatName != null))
            {
                newMedia.FormatID = this.formatIdx;
                newMedia.Format.Name = this.formatName;
            }
            if ((catIdx != -1) && (catName != null))
            {
                newMedia.CategoryID = this.catIdx;
                newMedia.Category.Name = this.catName;
            }
            if ((langIdx != -1) && (langName != null))
            {
                newMedia.LanguageID = this.langIdx;
                newMedia.Language.Name = this.langName;
            }
            if ((publIdx != -1) && (publName != null))
            {
                newMedia.PublisherID = this.publIdx;
                newMedia.Publisher.Name = this.publName;
            }




            this.Close();            

        }
       
    }
    
}
