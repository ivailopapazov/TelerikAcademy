using System;

class EmployeeRecord
{
    static void Main()
    {
        string firstName = "Henry";
        string lastName = "Kissinger";
        byte age = 90;
        char gender = 'm';
        int idNumber = 123456789;
        int uniqueNumber = 27560001;

        Console.WriteLine("Name: {0} {1}", firstName, lastName);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("age: " + age);
        Console.WriteLine("ID Number: " + idNumber);
        Console.WriteLine("Unique Employee Number: " + uniqueNumber);
    }
}