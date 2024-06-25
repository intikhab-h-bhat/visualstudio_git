using ClassLibraryBank;
using visualstudio_git;

Console.WriteLine("Welcome TO ABC Bank");
Console.WriteLine("_________________________________________");
Console.WriteLine("_________________________________________\n");

string strSelect = string.Empty;
EnterChoices();

 void EnterChoices()
{
    
    var selectChoice = new List<string> { "1", "2", "3" };
    Console.WriteLine(" Enter 1 to insert customer info \n Enter 2 to insert Employee\n");
    strSelect = Console.ReadLine();
    Console.Clear();
    CreateInfo();
}


IPerson cust;
void CreateInfo() {

    if (strSelect == "1")
    {
        Console.WriteLine("Create Customer");
        Console.WriteLine("_________________________________________");

        Console.WriteLine("Enter First Name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter the last anme");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter the Age");
        string age = Console.ReadLine();
        Console.WriteLine("Enter the Address");
        string address = Console.ReadLine();
        Console.WriteLine("Enter the Mobile No");
        string mobileNo = Console.ReadLine();
        Console.WriteLine("Enter the Email");
        string email = Console.ReadLine();
        Console.WriteLine("Enter the Account No");
        string acountNo = Console.ReadLine();
        Console.WriteLine("Enter the Balnce");
        string balance = Console.ReadLine();
        Console.WriteLine("Enter the Customer Id");
        string custId = Console.ReadLine();


        int intAge;
        int intMobileNo;
        int intCustId;
        double doubleBalance;

        int.TryParse(age, out intAge);
        int.TryParse(mobileNo, out intMobileNo);
        int.TryParse(custId, out intCustId);
        double.TryParse(balance, out doubleBalance);

        Console.Clear();
        Console.WriteLine("Customer Details");
        Console.WriteLine("_________________________________________");

        cust = new Customer(firstName, lastName, intAge, address, intMobileNo, email, acountNo, doubleBalance, intCustId);

        Console.WriteLine("Enter First Name");
        ((Customer)cust).Display();
        Console.WriteLine("_________________________________________\n");
        Console.WriteLine(" Enter (D or d) to Deposit Amount \n Enter (W or w) to Withdraw Amount\n");
        string strwDepositWithdraw = Console.ReadLine();
        if (strwDepositWithdraw == "D" || strwDepositWithdraw == "d")
        {
            ((Customer)cust).Deposit(500.0);
        }
        else if (strwDepositWithdraw == "W" || strwDepositWithdraw == "w")
        {
            ((Customer)cust).Withdraw(200.0);
        }
        else
        {
            Console.WriteLine("_________________________________________\n");
            strSelect = string.Empty;
            EnterChoices();
        }

}
else if (strSelect == "2")
{
    Console.WriteLine("Create Employee");
    Console.WriteLine("_________________________________________");

    Console.WriteLine("Enter First Name");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter the last anme");
    string lastName = Console.ReadLine();
    Console.WriteLine("Enter the Age");
    string age = Console.ReadLine();
    Console.WriteLine("Enter the Address");
    string address = Console.ReadLine();
    Console.WriteLine("Enter the Mobile No");
    string mobileNo = Console.ReadLine();
    Console.WriteLine("Enter the Email");
    string email = Console.ReadLine();
    Console.WriteLine("Enter the Designation");  
    string designation = Console.ReadLine();
    Console.WriteLine("Enter the Employee Id");
    string empId = Console.ReadLine();


    int intAge;
    int intMobileNo;
    int intEmpId;
   

    int.TryParse(age, out intAge);
    int.TryParse(mobileNo, out intMobileNo);
    int.TryParse(empId, out intEmpId);
   

    Console.Clear();
    Console.WriteLine("Employee Details");
    Console.WriteLine("_________________________________________");

    IPerson emp = new Employee(firstName, lastName, intAge, address, intMobileNo, email,designation, intEmpId);

    ((Employee)emp).Display();

    Console.WriteLine("_________________________________________\n");
    strSelect = string.Empty;
    EnterChoices();

}
    else if (strSelect == "3")
    {
        //((Customer)cust).Deposit(500.0);
        
    }
else if (strSelect == "4")
    {

       // ((Customer)cust).Withdraw(200.0);
    }



}



