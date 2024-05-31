using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualstudio_git
{
    internal class BankUser
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _email;
        private string _address;
        private long _phoneNo;


        public  BankUser(string fname,string lname, int age,string email,string address,long phoneNo)
        {
            this._firstName = fname;
            this._lastName = lname; 
            this._age = age;
            this._email = email;
            this._address = address;
           this._phoneNo = phoneNo;


        }


        public void DisplayInfo()
        {
            Console.WriteLine($"First Name : {_firstName} and Last Name : {_lastName}");
        }


    }

    class Employee : BankUser
    {


        private int _empId;
        private string _designation;

        public Employee(string fname, string lname, int age, string email, string address, long phoneNo, int empid, string designation):base(fname,lname,age,email,address,phoneNo)
        {
            this._empId = empid;
            this._designation = designation;

        }

    }


    class Customer : BankUser
    {


        private int _customerId;
        private string _designation;

        public Customer(string fname, string lname, int age, string email, string address, long phoneNo, int custid) : base(fname, lname, age, email, address, phoneNo)
        {
            this._customerId = custid;           

        }

    }
}
