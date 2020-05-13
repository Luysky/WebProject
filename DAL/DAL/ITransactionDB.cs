using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public interface ITransactionDB
    {
        List<Transaction> GetTransactionById(int id);
    }
}
