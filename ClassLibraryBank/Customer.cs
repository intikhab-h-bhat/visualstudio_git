using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBank
{
    internal class Customer:IPerson
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string mobileNo { get; set; }
        public string email { get; set; }
        public string accountNumber { get; set; }
        public double balance { get; private set; }
        public Customer() { 

        
        }

       
    }
}
