namespace DeepCopy;

public class Employee
{
    public string? Name { get; set; }
    public string? Department { get; set; }
    public Location Location { get; set; }

    public Employee Clone()
    {
        Employee employee = (Employee)this.MemberwiseClone();
        employee.Location = Location.Clone();
        return employee;
    }
}


public class Location
{
    public string? Country { get; set; }

    public Location Clone()
    {
        return (Location)this.MemberwiseClone();
    }
}