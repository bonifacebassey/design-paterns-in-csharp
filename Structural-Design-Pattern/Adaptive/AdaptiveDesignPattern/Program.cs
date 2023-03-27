
//Storing the Employees Data in a String Array
using AdaptiveDesignPattern.EmployeeAdapter;
using AdaptiveDesignPattern.Models;

string[,] employeesArray = new string[5, 4]
{
    {"101","John","SE","10000"},
    {"102","Smith","SE","20000"},
    {"103","Dev","SSE","30000"},
    {"104","Pam","SE","40000"},
    {"105","Sara","SSE","50000"}
};

//The Adapters make it possible to work with 2 incompatible Interfaces

Console.WriteLine("HR system passes employee string array to Adapter\n");

Console.WriteLine("\nUsing Object Adapter Design Pattern:");
Console.WriteLine("------------------------------------ \n");
IAdapter adapter = new UsingObjectAdapterPattern();
adapter.ProcessCompanySalary(employeesArray);

Console.WriteLine("\nUsing Class Adapter Design Pattern: ");
Console.WriteLine("----------------------------------- \n");
adapter = new UsingClassAdapterPattern();
adapter.ProcessCompanySalary(employeesArray);