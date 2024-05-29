using visualstudio_git;



ExtractFirstNameLastName firstNameLastName = new ExtractFirstNameLastName();

firstNameLastName.FullName = "Intikhab Hussain";

firstNameLastName.FirstName = firstNameLastName.FullName.Substring(0, firstNameLastName.FullName.IndexOf(" "));
firstNameLastName.LastName = firstNameLastName.FullName.Substring(firstNameLastName.FullName.IndexOf(" "));

Console.WriteLine($"First Name: {firstNameLastName.getFirstNameLastName()}");
Console.WriteLine($"Last Name: {firstNameLastName.LastName}");

