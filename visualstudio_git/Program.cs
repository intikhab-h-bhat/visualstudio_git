using System.ComponentModel;
using visualstudio_git;



var person= new Person("intikhab Hussain Bhat",43,"Nowgam Bypass Srinagar");

person.Introduce();


//InstanceCreationEditor of car  class
var car1 = new Car("Toyota","Caroola",2004,4);

car1.DispalayInfo();

var veh1 = new Vehicle("Toyota", "Caroola", 2004);

veh1.DispalayInfo();


ExtractFirstNameLastName firstNameLastName = new ExtractFirstNameLastName();

firstNameLastName.FullName = "Intikhab Hussain";

firstNameLastName.FirstName = firstNameLastName.FullName.Substring(0, firstNameLastName.FullName.IndexOf(" "));
firstNameLastName.LastName = firstNameLastName.FullName.Substring(firstNameLastName.FullName.IndexOf(" "));

Console.WriteLine($"First Name: {firstNameLastName.getFirstNameLastName()}");
Console.WriteLine($"Last Name: {firstNameLastName.LastName}");

