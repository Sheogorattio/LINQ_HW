using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressClass;

namespace CompanyClass
{
   
    public class Company
    {
        public string Name { get; set; }
        public string MainActivity { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public Dir Director { get; set; }
        public Address Addr { get; set; }
        public int EmployeeNumber { get; set; }

    }

    public class Dir
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

}
