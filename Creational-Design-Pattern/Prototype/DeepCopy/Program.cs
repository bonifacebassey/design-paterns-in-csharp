using DeepCopy;

Employee employee1 = new Employee();
employee1.Name = "Emeritus";
employee1.Department = "Engineering";
employee1.Location = new Location() { Country = "Nigeria" };

Employee employee2 = employee1.Clone();
employee2.Name = "Quintus";
employee2.Location.Country = "Togo";

Console.WriteLine("Emplpyee 1: ");
Console.WriteLine("Name: " + employee1.Name + ", Address: " + employee1.Location.Country + ", Department: " + employee1.Department);
Console.WriteLine("Emplpyee 2: ");
Console.WriteLine("Name: " + employee2.Name + ", Address: " + employee2.Location.Country + ", Department: " + employee2.Department);