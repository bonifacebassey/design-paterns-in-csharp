namespace FacadeDesignPatternRealTimeExample.SubSystems;

public class Validators
{
    public bool ValidateCustomer(Customer customer)
    {
        //Need to Validate the Customer Object
        Console.WriteLine("Customer Validated...");
        Console.WriteLine($"Name:{customer.Name}");
        Console.WriteLine($"Email:{customer.Email}");
        Console.WriteLine($"Mobile:{customer.MobileNumber}");
        Console.WriteLine($"Address:{customer.Address}");
        return true;
    }
}
