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
    Console.WriteLine(" Enter 1 to insert customer info \n Enter 2 to insert Employee");
    strSelect = Console.ReadLine();
}

if(strSelect == "1")
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

    IPerson cust = new Customer(firstName,lastName,intAge,address,intMobileNo,email,acountNo,doubleBalance,intCustId);

    cust.Display();
    
    EnterChoices();
    

}



