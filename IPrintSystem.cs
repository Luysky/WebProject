using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebProject
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IPrintSystem" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IPrintSystem
    {
        [OperationContract]
        string addAmmount(string username, float quotas);

        [OperationContract]
        string transferMoney(string username, float amount);

        [OperationContract]
        string getUsername(string getUsername);
    }
}
