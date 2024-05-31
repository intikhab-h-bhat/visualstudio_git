using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualstudio_git
{
    internal class Accounts
    {
        private string _accountNo;
        private string _acouyntType;
        private decimal _amountinbank;
        private int _customerId;

        public Accounts(string actno,string acttype,decimal bankamount,int custid) {
            
            this._accountNo = actno;
            this._acouyntType = acttype;    
            this._amountinbank = bankamount;
            this._customerId = custid;
            

        }

        // to get the balance amount in bank
        public decimal GetBalance()
        {
            return _amountinbank;
        }

        // this method update the amount
        public void UpdateBalance(decimal amount)
        {
            _amountinbank += amount;
        }

        public void GetAccountDetails() {

            Console.WriteLine($"Customer Id: {_customerId}");
            Console.WriteLine($"Account No : {_accountNo}");
            Console.WriteLine($"Account Type : {_acouyntType}");
            Console.WriteLine($"Amount in Bank : {_amountinbank}");
        
        }


        public string GetAcountNo()
        {
            return _accountNo;
        }

    }
}
