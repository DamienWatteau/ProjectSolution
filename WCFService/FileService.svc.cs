using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.models;
namespace WCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class FileService : IFileService
    {
        public void SendFile(InitialFile initialFile)
        {
            FileDecrypt fileDecrypt = new FileDecrypt();
            fileDecrypt.FilePath = initialFile.FilePath;
            fileDecrypt.Key = "ABCD";
            fileDecrypt.FileContentDecrypted= "pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.";
            // Envoie à JAX-WS
            String [] myArray = new String[] { fileDecrypt.FilePath, fileDecrypt.Key, fileDecrypt.FileContentDecrypted };
            var service = new ServiceReferenceJava.DecipherClient().SendFile(myArray); 
            System.Diagnostics.Debug.WriteLine(service);
        }

        public void ReceiveFile(FileResult name)
        {
            System.Diagnostics.Debug.WriteLine("RESULT");
            TextWriter tw = new StreamWriter("C:\\Users\\Damien\\Desktop\\Oracle\\projetdamien.txt", true);
            tw.WriteLine(name.Fiability);
            tw.Close();

        }

        private void SendEmailToUser()
        {
            //TO FIX : change mail by user mail
            Email.SendEmail("damien.watteau@viacesi.fr");
        }
    }
}
