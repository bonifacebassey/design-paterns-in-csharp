using FacadeDesignPatternRealTimeExample.SubSystems;

namespace FacadeDesignPatternRealTimeExample.Facade;

public class CustomerRegistration
{
    public bool RegisterCustomer(Customer customer)
    {
        //Step1: Validate the Customer
        Validators validator = new Validators();
        var isValid = validator.ValidateCustomer(customer);

        //Step2: Save the Customer Object into the database
        CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
        var isSaved = customerDataAccessLayer.SaveCustomer(customer);

        //Step3: Send the Registration Email to the Customer
        Email email = new Email();
        email.SendRegistrationEmail(customer);

        return true;
    }
}
