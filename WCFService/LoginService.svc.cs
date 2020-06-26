using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class LoginService : ILoginService
    {
        public models.ClientResult Authentification(models.Client client)
        {
            models.ClientResult clientResult = new models.ClientResult();
            clientResult.Status = false;
            
            using (var entities = new masterEntities())
            foreach (var clientBDD in entities.Clients)
            {
                if (clientBDD.Username == client.Username && clientBDD.Password == client.Password && clientBDD.TokenApp == client.TokenApp)
                {
                    clientResult.Status = true;
                    clientResult.TokenUser = clientBDD.TokenUser;
                }
            }
            return clientResult;
        }

    }
}
