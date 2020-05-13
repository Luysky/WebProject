using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class TransactionManager : ITransactionManager
    {

        private ITransactionDB TransactionDb { get; }

        public TransactionManager(ITransactionDB transactionDb)
        {
            TransactionDb = transactionDb;
        }

        public List<Transaction> GetTransactionById(int Id)
        {
            return TransactionDb.GetTransactionById(Id);
        }
    }
}
