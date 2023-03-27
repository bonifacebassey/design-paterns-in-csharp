using AdaptiveDesignPattern.Models;

namespace AdaptiveDesignPattern.EmployeeAdapter;

public class UsingClassAdapterPattern : ThirdPartyBillingSystem, IAdapter
{
    public void ProcessCompanySalary(string[,] employees)
    {
        var listEmployee = new List<Employee>();

        for (int i = 0; i < employees.GetLength(0); ++i)
        {
            var id = employees[i, 0];
            var name = employees[i, 1];
            var designation = employees[i, 2];
            var salary = employees[i, 3];
            listEmployee.Add(new Employee(Convert.ToInt32(id), name, designation, Convert.ToDecimal(salary)));
        }

        Console.WriteLine("Adapter converted Array of Employee to List of Employee");
        Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");

        // call the Base Class ProcessSalary Method to Process the Salary
        ProcessSalary(listEmployee);
    }
}
