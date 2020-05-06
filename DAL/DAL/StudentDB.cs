using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class StudentDB : IStudentDB
    {
        private string connectionString = null;
        public StudentDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        }

        public List<Student> GetStudentById(int Id)
        {
            List<Student> result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))

                {
                    string query = "SELECT * from Student where IdStudent = @Id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (result == null)
                                result = new List<Student>();
                            Student student = new Student();
                            student.IdStudent = (int)dr["IdStudent"];
                            student.UserName = (string)dr["UserName"];
                            student.Password = (string)dr["Password"];
                            student.Name = (string)dr["Name"];
                            student.Firstname = (string)dr["Firstname"];
                            student.Credit = (float)dr["Credit"];

                            result.Add(student);
                        }
                    }
                }
            }

            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
    }
}
