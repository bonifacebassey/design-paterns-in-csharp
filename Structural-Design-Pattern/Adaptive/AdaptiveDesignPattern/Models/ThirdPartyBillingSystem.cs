namespace AdaptiveDesignPattern.Models;

public class ThirdPartyBillingSystem
{
    public void ProcessSalary(List<Employee> employees)
    {
        employees.ForEach(employee =>
        {
            Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
        });
    }
}
