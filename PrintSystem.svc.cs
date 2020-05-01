using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebProject
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PrintSystem" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez PrintSystem.svc ou PrintSystem.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class PrintSystem : IPrintSystem
    {
        public string addAmmount(string username, float quotas)
        {
            throw new NotImplementedException();
        }

        public string getUsername(string getUsername)
        {
            throw new NotImplementedException();
        }

        public string transferMoney(string username, float amount)
        {
            throw new NotImplementedException();
        }
    }
}
