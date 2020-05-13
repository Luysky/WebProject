using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO
{

    [DataContract]
    public class Student
    {

        [DataMember]
        public int IdStudent { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public float Credit{ get; set; }   


        [DataMember]
        public List<Student> studentList { get; set; }
    }


 
}
