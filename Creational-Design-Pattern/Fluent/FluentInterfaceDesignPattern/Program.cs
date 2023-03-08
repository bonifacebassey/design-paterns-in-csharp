
using FluentInterfaceDesignPattern;

Employee employee = new Employee();

var e = employee.NameOfEmployee("Spiritus Agustus")
        .Born("01/11/1990")
        .WorkingOn("Engineering")
        .StaysAt("Nigeria");

Console.WriteLine($"Fluent Employee:\n\t"
                  + $"FullName: {e.FullName}\n\t"
                  + $"DateOfBirth: {e.DateOfBirth}\n\t"
                  + $"Department: {e.Department}\n\t"
                  + $"Address: {e.Address}");