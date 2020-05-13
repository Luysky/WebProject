using DAL;
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
        List<StudentDB> GetStudentById(int Id);


        [OperationContract]
        string addAmmount(string username, float quotas);

        [OperationContract]
        string transferMoney(string username, float amount);

        [OperationContract]
        string getUsername(string getUsername);

  

        [OperationContract]
        Student GetDataUsingDataContract(Student student);


    }

    [DataContract]
    public class Student
    {

        private int M_IdStudent;
        private string M_Username;
        private string M_Password;
        private string M_Name;
        private string M_Firstname;
        private float M_Credit;


        [DataMember]
        public int IdStudent { get { return M_IdStudent; } set { M_IdStudent = value; } }

        [DataMember]
        public string UserName { get { return M_Username; } set { M_Username = value; } }

        [DataMember]
        public string Password { get { return M_Password; } set { M_Password = value; } }

        [DataMember]
        public string Name { get { return M_Name; } set { M_Name = value; } }

        [DataMember]
        public string Firstname { get { return M_Firstname; } set { M_Firstname = value; } }

        [DataMember]
        public float Credit { get { return M_Credit; } set { M_Credit = value; } }

    }
}
