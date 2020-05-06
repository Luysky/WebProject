using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public int IdTransaction { get; set; }
        [DataMember]
        public int IdStudent { get; set; }
        [DataMember]
        public float Mouvement { get; set; }

    }
}
