using System.ComponentModel;
using visualstudio_git;

Console.WriteLine("Welcome to ABC Bank");
Console.WriteLine("_________________________________________");
Console.WriteLine("_________________________________________\n");

var selectEmpOrCust = new List<string> { "1", "2", "3" };
Console.WriteLine(" Enter 1 to insert customer info \n Enter 2 to insert Employee Info \n Enter 3 for Transaction");
string strSelect = Console.ReadLine();



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
    Console.WriteLine("Enter the Email");
    string email = Console.ReadLine();
    Console.WriteLine("Enter the Address");
    string address = Console.ReadLine();
    Console.WriteLine("Enter the Mobile No");
    string mobileNo = Console.ReadLine();
    Console.WriteLine("Enter the Customer Id");
    string custId = Console.ReadLine();


    int intAge;
    long longMobileNo;
    int intCustId;

    int.TryParse(age, out intAge);
    long.TryParse(mobileNo, out longMobileNo);
    int.TryParse(custId, out intCustId);

    Console.Clear();
    Console.WriteLine("Customer Details");
    Console.WriteLine("_________________________________________");
    var customer1 = new Customer(firstName, lastName, intAge, email, address, longMobileNo, intCustId);
    //var customer1 = new Customer("Intikhab Hussain","Bhat",43,"intikhabh@gmail.com","Nowgam By-Pass Srinagar",8491021591,1);
    customer1.DisplayInfo();

    Console.WriteLine("\n");
    Console.WriteLine("Create Customer Account");
    Console.WriteLine("_________________________________________");

    Console.WriteLine("Enter Account No");
    string actNo= Console.ReadLine();
    Console.WriteLine("Enter the Account Type");
    string actType = Console.ReadLine();
    Console.WriteLine("Enter the Amount to be deposited");
    string amountDeposted = Console.ReadLine();
    int intAmountDeposit;
    int.TryParse(amountDeposted, out intAmountDeposit);


    Console.Clear();
    Console.WriteLine("Customer Account Details");
    Console.WriteLine("_________________________________________");
    var acountdetails = new Accounts(actNo, actType, intAmountDeposit, customer1.GetCustId());

    acountdetails.GetAccountDetails();

    Console.WriteLine("\n");
    Console.WriteLine("Transaction Details");
    Console.WriteLine("_________________________________________");
    var transDetails = new Transactions(acountdetails.GetAcountNo(), -500, DateTime.Now, "Withdrawl");

    //Console.WriteLine($"Amount in Bank : {acountdetails.GetBalance()}");

    transDetails.GetTransactionDetails();
    acountdetails.UpdateBalance(transDetails.GetWithdrawlAmount());
    Console.WriteLine($"Balance in Bank : {acountdetails.GetBalance()}");

}
else
{
    Console.WriteLine("\n");
    Console.WriteLine("Create Employee");
    Console.WriteLine("_________________________________________");

    Console.WriteLine("Enter First Name");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter the last anme");
    string lastName = Console.ReadLine();
    Console.WriteLine("Enter the Age");
    string age = Console.ReadLine();
    Console.WriteLine("Enter the Email");
    string email = Console.ReadLine();
    Console.WriteLine("Enter the Address");
    string address = Console.ReadLine();
    Console.WriteLine("Enter the Mobile No");
    string mobileNo = Console.ReadLine();
    Console.WriteLine("Enter the Employee Id");
    string empId = Console.ReadLine();
    Console.WriteLine("Enter Designation");
    string designation = Console.ReadLine();


    int intAge;
    long longMobileNo;
    int intEmpId;

    int.TryParse(age, out intAge);
    long.TryParse(mobileNo, out longMobileNo);
    int.TryParse(empId, out intEmpId);

    Console.Clear();
    Console.WriteLine("Employee Details");
    Console.WriteLine("_________________________________________");
    var empDetails = new Employee(firstName, lastName, intAge, email, address, longMobileNo, intEmpId, designation);

    empDetails.DisplayInfo();

}


//var person= new Person("intikhab Hussain Bhat",43,"Nowgam Bypass Srinagar");

//person.Introduce();


////InstanceCreationEditor of car  class
//var car1 = new Car("Toyota","Caroola",2004,4);

//car1.DispalayInfo();

//var veh1 = new Vehicle("Toyota", "Caroola", 2004);

//veh1.DispalayInfo();
//Console.WriteLine(veh1.GetModel());
//Console.WriteLine(veh1.GetYear());

//veh1.SetYear(2008);
//veh1.DispalayInfo();



//ExtractFirstNameLastName firstNameLastName = new ExtractFirstNameLastName();

//firstNameLastName.FullName = "Intikhab Hussain";

//firstNameLastName.FirstName = firstNameLastName.FullName.Substring(0, firstNameLastName.FullName.IndexOf(" "));
//firstNameLastName.LastName = firstNameLastName.FullName.Substring(firstNameLastName.FullName.IndexOf(" "));

//Console.WriteLine($"First Name: {firstNameLastName.getFirstNameLastName()}");
//Console.WriteLine($"Last Name: {firstNameLastName.LastName}");

