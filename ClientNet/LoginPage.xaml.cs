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
using WCFService.models;

namespace ClientNet
{
    /// <summary>
    /// Logique d'interaction pour LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
       
        private void btnSubmitClick(object sender, RoutedEventArgs e)
        {
            checkLogin();
        }

        private void checkLogin()
        {
            Client client = new Client();
            client.TokenApp = models.ClientProperties.getInstance().TokenInfo.TokenApp;
            client.Username = username.Text;
            client.Password = password.Password;

            var service = new ServiceReferenceLogin.LoginServiceClient().Authentification(client);
            if (service.Status)
            {
                error.Content = "";
                models.ClientProperties.getInstance().TokenInfo.TokenUser = service.TokenUser;
                
                change_frame();
            }
            else
            {
                error.Content = "Sorry, those details don't match. Check you've typed them correctly.";
            }

        }

        private void change_frame()
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
            {
                mainWindow.Main.Content = new DecryptionPage();
            }
        }



    }
}
