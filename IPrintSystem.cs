using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebDTO;

namespace WebProject
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IPrintSystem" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IPrintSystem
    {

        [OperationContract]
        Student GetDataUsingDataContract(Student student);

        [OperationContract]
        Student GetStudentById(int Id);

        [OperationContract]
        Student GetStudentByUserName(string UserName);

        [OperationContract]
        int Authentification(string UserName, string Pass);

        [OperationContract]
        void AuthentificationNotification(int number);

        [OperationContract]
        string GetPassword(int id, string pass);

        [OperationContract]
        int GetIdStudent(string login);

        [OperationContract]
        double AddAmount(Student student, string UserName, double money);

        [OperationContract]
        int ConvertCredit(Student student, string UserName, string Pass);

        [OperationContract]
        Student AuthenficationUser(string UserName);

        [OperationContract]
        int UpdateTransaction(Student student, double mouve);

        [OperationContract]
        List<Test> GetTransactionById(int id);

        /*
        [OperationContract]
        double GetMovement(Test transa);
        */

        /*
       [OperationContract]
       void PrintTransactionList(Test[] test);
       */

    }


}
