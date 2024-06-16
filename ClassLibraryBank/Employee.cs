using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBank
{
    public class Employee:IPerson
    {


        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public int mobileNo { get; set; }
        public string email { get; set; }
     
        public string designation { get; private set; }
        public int empId { get; private set; }
        public Employee(string fname, string lname, int age, string address, int mobileno, string email, string desig, int empid)
        {


            firstName = fname;
            lastName = lname;
            age = age;
            address = address;
            mobileNo = mobileno;
            email = email;
            designation = desig;
           empId = empid;



        }

        public void Display()
        {
            Console.WriteLine($"Employee Id: {empId}");
            Console.WriteLine($"Designation: {designation}");
          
            Console.WriteLine($"Full Name: {firstName}  {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Mobile No: {mobileNo}");
            Console.WriteLine($"Address: {address}");


        }


    }
}
