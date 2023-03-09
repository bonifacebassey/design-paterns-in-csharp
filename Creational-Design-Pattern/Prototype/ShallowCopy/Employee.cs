namespace ShallowCopy;

public class Employee
{
    public string? Name { get; set; }
    public string? Department { get; set; }
    public Location Location { get; set; }

    public Employee Clone()
    {
        return (Employee)this.MemberwiseClone();
    }
}


public class Location
{
    public string? Country { get; set; }
}