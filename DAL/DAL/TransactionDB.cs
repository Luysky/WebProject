using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TransactionDB : ITransactionDB
    {
        private string connectionString = null;
        public TransactionDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        }

        public List<Transaction> GetTransactionById(int Id)
        {
            List<Transaction> result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * from Transaction where IdTransaction = @Id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if(result==null)
                            result = new List<Transaction>();
                            Transaction trasaction = new Transaction();

                            trasaction.IdTransaction = (int)dr["IdTransaction"];
                            trasaction.IdStudent = (int)dr["IdStudent"];
                            trasaction.Mouvement = (float)dr["Mouvement"];
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
