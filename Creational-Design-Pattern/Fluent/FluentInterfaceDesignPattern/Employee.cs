namespace FluentInterfaceDesignPattern;

public class Employee
{
    public string? FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Department { get; set; }
    public string? Address { get; set; }

    public Employee NameOfEmployee(string fullName)
    {
        FullName = fullName;
        return this;
    }

    public Employee Born(string dateOfBirth)
    {
        DateOfBirth = Convert.ToDateTime(dateOfBirth);
        return this;
    }

    public Employee WorkingOn(string department)
    {
        Department = department;
        return this;
    }

    public Employee StaysAt(string address)
    {
        Address = address;
        return this;
    }
}
