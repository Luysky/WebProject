using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebBLL;
using WebDAL;
using WebDTO;

namespace WebProject
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PrintSystem" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez PrintSystem.svc ou PrintSystem.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    
    
    public class PrintSystem : IPrintSystem
    {
    

        public Student GetDataUsingDataContract(Student student)
        {
            throw new NotImplementedException();
        }

         

        public Student GetStudentById(int Id)
        {

            IStudentDB studentDB = new StudentDB();
            IStudentManager studentManager = new StudentManager(studentDB);

            Student student = studentManager.GetStudentById(Id);


            return student;
        }

        public int GetIdStudent(string login)
        {
            IStudentDB studentDB = new StudentDB();
            IStudentManager studentManager = new StudentManager(studentDB);

            int IdStudent = studentManager.GetIdStudent(login);


            return IdStudent;

        }

        public string GetPassword(int id, string login)
        {
            IStudentDB studentDB = new StudentDB();
            IStudentManager studentManager = new StudentManager(studentDB);

            string password = studentManager.GetPassword(id, login);


            return password;

        }


        public Student GetStudentByUserName(string UserName)
        {

            IStudentDB studentDB = new StudentDB();
            IStudentManager studentManager = new StudentManager(studentDB);

            Student student = studentManager.GetStudentByUserName(UserName);


            return student;
        }

        public Student AuthenficationUser(string UserName)
        {
            IStudentDB studentDB = new StudentDB();
            IStudentManager studentManager = new StudentManager(studentDB);

            Student student = studentManager.GetStudentByUserName(UserName);

            return student;

        }



        public int Authentification(string UserName, string Pass)
        {

            IStudentDB studentDB = new StudentDB();
            IStudentManager studentManager = new StudentManager(studentDB);

            int IdStudent = studentManager.GetIdStudent(UserName);
            string Password = studentManager.GetPassword(IdStudent, Pass);

            if (Pass == Password)
            {
                
              return IdStudent;
            }
            else
            {
                
                return 0;
            }
        }


        public void AuthentificationNotification (int number)
        {

            if (number > 0)
            {
                Console.WriteLine("Authentification successfull") ;
            }
            else
            {
                Console.WriteLine("Authentification denied");
            }
        }
   

     
        public double AddAmount(Student student, string UserName, double money)
        {
            IStudentDB studentDB = new StudentDB();
            IStudentManager studentManager = new StudentManager(studentDB);

            return studentManager.AddAmount(student, UserName, money);
        }

       public int ConvertCredit(Student student, string UserName, string Pass)
        {
            IStudentDB studentDB = new StudentDB();
            IStudentManager studentManager = new StudentManager(studentDB);

            double credit = 0;
            int pages = 0;
            int userId = 0;

            userId = Authentification(UserName,Pass);

            if (userId > 0)
            {

                credit = student.Credit;

                pages = Convert.ToInt32(credit / 0.08);

            }
            else
            {
                return 0;
            }

            return pages;

        }

        public int UpdateTransaction(Student student, double mouve)
        {
            IStudentDB studentDB = new StudentDB();
            IStudentManager studentManager = new StudentManager(studentDB);

            ITransactionDB transactionDB = new TransactionDB();
            ITransactionManager transactionManager = new TransactionManager(transactionDB);

            return transactionManager.UpdateTransaction(student, mouve);

        }

        public List<Test> GetTransactionById(int id)
        {
            ITransactionDB transactionDB = new TransactionDB();
            ITransactionManager transactionManager = new TransactionManager(transactionDB);


            return transactionManager.GetTransactionById(id);
        }


        /*
     public void PrintTransactionList(Test[] test)
     {
        Console.WriteLine("Salut ");
         int count = 0;

         foreach (Test testPrint in test)
         {
             Test i = testPrint;

             double argent = i.Mouvement;

             count++;
             Console.WriteLine($"Transaction nr. #{count}: {argent}");
         }
     }
     */


        /*
        public double GetMovement(Test transa)
        {
            ITransactionDB transactionDB = new TransactionDB();
            ITransactionManager transactionManager = new TransactionManager(transactionDB);

            double mouvement = transactionManager.GetTransactionById(transa.IdTransaction).Mouvement;

            return mouvement;
        }
        */

    }
}
