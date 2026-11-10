using System;

// Defines the Employee class
public class Employee
{
    // Property to hold the employee's ID
    public int Id { get; set; }
    
    // Property to hold the employee's first name
    public string FirstName { get; set; }
    
    // Property to hold the employee's last name
    public string LastName { get; set; }

    // Overloads the "==" operator to compare two Employee objects
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Checks if both objects reference the same memory location or if both are null
        if (ReferenceEquals(emp1, emp2))
        {
            return true; // They are the exact same object in memory, or both null
        }
        
        // Checks if either object is null to avoid null reference exceptions
        if (emp1 is null || emp2 is null)
        {
            return false; // If only one is null, they cannot be equal
        }
        
        // Compares the Id property of both objects to determine equality
        return emp1.Id == emp2.Id;
    }

    // Overloads the "!=" operator as it must always be paired with the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Reuses the "==" operator logic and negates it
        return !(emp1 == emp2);
    }
    
    // Best Practice: Overriding Equals is recommended by C# when overloading equality operators
    public override bool Equals(object obj)
    {
        // Casts the object to an Employee and uses our custom "==" operator to check equality
        return this == (Employee)obj;
    }

    // Best Practice: Overriding GetHashCode is required by C# when overriding Equals
    public override int GetHashCode()
    {
        // Generates a hash code based solely on the Id property
        return Id.GetHashCode();
    }
}
