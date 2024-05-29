using visualstudio_git;


var person= new Person("intikhab Hussain Bhat",43);
person.Introduce();




ExtractFirstNameLastName firstNameLastName = new ExtractFirstNameLastName();

firstNameLastName.FullName = "Intikhab Hussain";

firstNameLastName.FirstName = firstNameLastName.FullName.Substring(0, firstNameLastName.FullName.IndexOf(" "));
firstNameLastName.LastName = firstNameLastName.FullName.Substring(firstNameLastName.FullName.IndexOf(" "));

Console.WriteLine($"First Name: {firstNameLastName.getFirstNameLastName()}");
Console.WriteLine($"Last Name: {firstNameLastName.LastName}");

