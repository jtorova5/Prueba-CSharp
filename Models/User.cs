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

}
