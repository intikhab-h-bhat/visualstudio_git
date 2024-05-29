using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualstudio_git
{
    internal class ExtractFirstNameLastName
    {
        private string _fullName;
        private string _firstName;
        private string _lastName;

        public string FullName { get => _fullName; set => _fullName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        
        public string getFirstNameLastName()
        {
            return _firstName;
        }
       

    }
}
