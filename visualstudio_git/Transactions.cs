using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualstudio_git
{
    internal class Transactions
    {
        private string _accountNo;  // Reference to the account involved in the transaction
        private decimal _transAmount;
        private DateTime _transDate;
        private string _transType;


        public Transactions(string actNo,decimal amount,DateTime date, string transtype) { 

                this._accountNo = actNo;
                this._transAmount = amount; 
                this._transDate = date;
                this._transType = transtype;    
                
        
        }


        public void GetTransactionDetails()
        {
            //Console.WriteLine($"Acount No : {_accountNo}");
            Console.WriteLine($"Transaction Type: {_transType}");
            Console.WriteLine($"Transaction Amount: {_transAmount}");
            Console.WriteLine($"Transaction Date : {_transDate}");
        }

        public decimal GetWithdrawlAmount()
        {
            return _transAmount;
        }


    }
}
