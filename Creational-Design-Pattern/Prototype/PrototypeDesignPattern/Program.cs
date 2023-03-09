
using PrototypeDesignPattern;

Employee employee1 = new Employee();
employee1.Name = "Emeritus";
employee1.Department = "Engineering";

Employee employee2 = employee1;
employee2.Name = "Quintus"; // changes the value of employee1.Name 

Console.WriteLine("Emplpyee 1: ");
Console.WriteLine("Name: " + employee1.Name + ", Department: " + employee1.Department);
Console.WriteLine("Emplpyee 2: ");
Console.WriteLine("Name: " + employee2.Name + ", Department: " + employee2.Department);


/* The assignment (=) operator copies the reference and not the object itself. 
 * Both objects will share the same memory address and thus, are the same.
 * Object cloning is meant to address this issue
 */