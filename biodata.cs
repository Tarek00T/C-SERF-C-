using System;

namespace StudentInformation
{
class Program
{
    static void Main(string[] args)
    {
        // Information about Md Tarek Miah
        string name = "Md Tarek Miah";
        string studentId = "231-115-208";
        string section = "F";
        string house = "Habiganj (Olipur)";
        int age = 23;
        string maritalStatus = "unmarried";
        string[] favoriteLanguages = { "c", "c++", "java", "python", "c#", "php" };

        // Print the information
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"ID: {studentId}");
        Console.WriteLine($"Section: {section}");
        Console.WriteLine($"House: {house}");
        Console.WriteLine($"Age: {age} years old");
        Console.WriteLine($"Marital Status: {maritalStatus}");
        Console.WriteLine($"Favorite Languages: {string.Join(", ", favoriteLanguages)}");
    }
}
}

