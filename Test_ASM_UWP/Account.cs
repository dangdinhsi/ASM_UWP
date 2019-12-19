using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ASM_UWP
{
    class Account
    {
        public long id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string avatar { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string introduction { get; set; }
        public SelectGender gender { get; set; }
        public DateTime birthday { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public SelectStatus status { get; set; }
    }

    public enum SelectStatus
    {
        active =1,
        de_active =0,
        deleted=-1
    }

    public enum SelectGender
    {
        Male =1,
        Female =2,
        Other =3
    }
}
