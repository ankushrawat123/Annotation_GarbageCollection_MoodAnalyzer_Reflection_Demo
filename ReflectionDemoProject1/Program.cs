// See https://aka.ms/new-console-template for more information
using ReflectionDemoProject1;
Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to reflection Demo");
CustomerInfo obj = new CustomerInfo();
ReflectionOnCustomer.ReflectionTest();
obj.Id = -2;
Console.WriteLine(obj.Id);
Console.ReadKey();

