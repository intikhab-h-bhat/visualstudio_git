using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualstudio_git
{
    internal class Person
    {
        private string _name;
        private int _age;
        private string _address;
        //private string _city;

        public Person(string name,int age,string address)
        {
            this._name = name;
            this._age = age;
            this._address = address;


        }

        public void Introduce()
        {

            Console.WriteLine($"Hello my name is {_name} and my age is {_age} and my address is {_address}");
        }

     

       
    }
}
