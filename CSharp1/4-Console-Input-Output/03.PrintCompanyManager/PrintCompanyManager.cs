using System;

class PrintCompanyManager
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Enter company web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Enter manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager's phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        string companyManager = managerFirstName + " " + managerLastName;

        Console.WriteLine("Company information:");
        Console.WriteLine("name: {0}, address: {1}, phone number: {2}, fax number: {3}, web site: {4}, manager: {5}", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite, companyManager);
        Console.WriteLine("Manager information:");
        Console.WriteLine("first name: {0}, last name: {1}, age: {2}, phone number: {3}", managerFirstName, managerLastName, managerAge, managerPhoneNumber);

    }
}
