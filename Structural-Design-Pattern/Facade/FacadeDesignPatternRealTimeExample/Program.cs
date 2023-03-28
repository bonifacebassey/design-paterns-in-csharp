
//The Client will use the Facade Interface instead of the Subsystems

using FacadeDesignPatternRealTimeExample.Facade;
using FacadeDesignPatternRealTimeExample.SubSystems;

var customer = new Customer
{
    Name = "Pilatus",
    Email = "pilatus@gmx.org",
    MobileNumber = "02084921167",
    Address = "714B, Obudu, Nigeria"
};

CustomerRegistration customerRegistration = new();
customerRegistration.RegisterCustomer(customer);
