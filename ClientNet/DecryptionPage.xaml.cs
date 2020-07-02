using System;
using System.Collections.Generic;
using System.IO;
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
using WCFService.models;
using Path = System.IO.Path;

namespace ClientNet
{
    /// <summary>
    /// Logique d'interaction pour ChooseFilePage.xaml
    /// </summary>
    public partial class DecryptionPage : Page
    {

        public DecryptionPage()
        {
            InitializeComponent();
            FillCombobox();
        }

        private void FillCombobox()
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += "\\CryptedFiles";

            string[] dirs = Directory.GetFiles(_filePath);
            for (int i = 0; i < dirs.Length; i++)
            {
                FileNameComboBox.Items.Add(dirs[i]);
            }
            FileNameComboBox.Items.Refresh();
        }


        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            // Init serizalize class
            InitialFile file = new InitialFile();
            file.TokenApp = models.ClientProperties.getInstance().TokenInfo.TokenApp;
            file.TokenUser = models.ClientProperties.getInstance().TokenInfo.TokenUser;
            file.FilePath = FileNameComboBox.SelectedItem.ToString();
            file.Login = models.ClientProperties.getInstance().Username;

           new ServiceReferenceFile.FileServiceClient().SendFile(file);
        }
    }
}
