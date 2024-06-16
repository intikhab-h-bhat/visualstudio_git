﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBank
{
    public class Customer:IPerson
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public int mobileNo { get; set; }
        public string email { get; set; }
        public string accountNumber { get; set; }
        public double balance { get; private set; }
        public int custId { get; private set; }
        public Customer(string fname,string lname,int age,string address,int mobileno,string email,string actno,double balance,int custid) { 

        
            firstName = fname;
            lastName = lname;
            age = age;
            address = address;
            mobileNo = mobileno;
            email = email;
            accountNumber = actno;
            balance = balance; 
            custId = custid;
                        
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C} to account {accountNumber}. New balance is {balance:C}.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from account {accountNumber}. New balance is {balance:C}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Customer Id: {custId}");
            Console.WriteLine($"Account No: {accountNumber}");
            Console.WriteLine($"Amount Balance: {balance}");
            Console.WriteLine($"Full Name: {firstName}  {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Mobile No: {mobileNo}");
            Console.WriteLine($"Address: {address}");


        }

       
    }
}
