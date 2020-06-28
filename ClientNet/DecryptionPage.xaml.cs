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

namespace ClientNet
{
    /// <summary>
    /// Logique d'interaction pour ChooseFilePage.xaml
    /// </summary>
    public partial class DecryptionPage : Page
    {
        Microsoft.Win32.OpenFileDialog openFileDlg=null;

        public DecryptionPage()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            openFileDlg = new Microsoft.Win32.OpenFileDialog();

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                FileNameTextBox.Text = openFileDlg.FileName;
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            InitialFile file = new InitialFile();
            file.TokenApp = models.ClientProperties.getInstance().TokenInfo.TokenApp;
            file.TokenUser = models.ClientProperties.getInstance().TokenInfo.TokenUser;
            file.TxtFile = openFileDlg.FileName;

            new ServiceReferenceFile.FileServiceClient().SendFile(file);
        }
    }
}
