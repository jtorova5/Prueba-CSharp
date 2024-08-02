using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro.Models;

public class User
{
    protected Guid Id { get; set; }
    protected string Name { get; set; }
    protected string LastName { get; set; }
    protected string TypeDocument { get; set; }
    protected string IdentificationNumber { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string Email { get; set; }
    protected string PhoneNumber { get; set; }
    protected string Address { get; set; }

    protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        TypeDocument = typeDocument;
        IdentificationNumber = identificationNumber;
        BirthDate = birthDate;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
    }

    protected void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Type Document: {TypeDocument}");
        Console.WriteLine($"Identification Number: {IdentificationNumber}");
        Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Address: {Address}");
    }

    protected int CalculateAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    protected void ShowAge()
    {
        Console.WriteLine($"Age: {CalculateAge()}");
    }
}
