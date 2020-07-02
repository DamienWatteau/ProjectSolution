using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.Controllers;
using WCFService.models;
namespace WCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class FileService : IFileService
    {
        public void SendFile(InitialFile initialFile)
        {
            // Génération de la clé
            KeyGenerator.KeyGen(initialFile.FilePath);
            String pdfPath = PdfFileCreator.PdfCreator();
            Email.SendEmail(initialFile.Login, pdfPath);
        }
    }
}
