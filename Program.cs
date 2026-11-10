using System;

// Defines the main entry point class of the console application
class Program
{
    // The Main method where the program begins execution
    static void Main(string[] args)
    {
        // Instantiates the first Employee object
        Employee employee1 = new Employee();
        // Assigns an integer value to the Id property of employee1
        employee1.Id = 101;
        // Assigns a string value to the FirstName property of employee1
        employee1.FirstName = "Jane";
        // Assigns a string value to the LastName property of employee1
        employee1.LastName = "Doe";

        // Instantiates the second Employee object
        Employee employee2 = new Employee();
        // Assigns a different integer value to the Id property of employee2
        employee2.Id = 102;
        // Assigns a string value to the FirstName property of employee2
        employee2.FirstName = "John";
        // Assigns a string value to the LastName property of employee2
        employee2.LastName = "Smith";

        // Instantiates a third Employee object to properly test an equality match
        Employee employee3 = new Employee();
        // Assigns the exact same Id value as employee1 to test the overloaded operator
        employee3.Id = 101;
        // Assigns a string value to the FirstName property of employee3
        employee3.FirstName = "Jane";
        // Assigns a string value to the LastName property of employee3
        employee3.LastName = "Doe";

        // Compares employee1 and employee2 using the overloaded "==" operator
        bool areDifferentEmployeesEqual = employee1 == employee2;
        // Prints the result of the comparison to the console (Should be False)
        Console.WriteLine($"Are employee1 and employee2 equal? {areDifferentEmployeesEqual}");

        // Compares employee1 and employee3 using the overloaded "==" operator
        bool areSameEmployeesEqual = employee1 == employee3;
        // Prints the result of the comparison to the console (Should be True)
        Console.WriteLine($"Are employee1 and employee3 equal? {areSameEmployeesEqual}");

        // Keeps the console window open until the user presses a key
        Console.ReadLine();
    }
}
