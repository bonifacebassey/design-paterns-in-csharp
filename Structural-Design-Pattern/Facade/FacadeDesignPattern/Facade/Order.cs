using FacadeDesignPattern.SubSystems;

namespace FacadeDesignPattern.Facade;

public class Order
{
    public void PlaceOrder()
    {
        Console.WriteLine("Place Order Started\n");

        //Get the Product Details
        var product = new Product();
        product.GetProductDetails();

        //Make the Payment
        var payment = new Payment();
        payment.MakePayment();

        //Send the Invoice
        var invoice = new Invoice();
        invoice.Sendinvoice();

        Console.WriteLine("\nOrder Placed Successfully");
    }
}
