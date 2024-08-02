using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro.Models;

public class Customer : User
{
    public string MembershipLevel { get; set; }
    public string PreferredPaymentMethod { get; set; }

    public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string membershipLevel, string preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
    {
        MembershipLevel = membershipLevel;
        PreferredPaymentMethod = preferredPaymentMethod;
    }

    public void UpdateMembershipLevel()
    {
        Console.Write("¿Cuál es el nivel de su membresia? ");
        MembershipLevel = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Nivel de membresía actualizado a: {MembershipLevel}");
    }

    public string GetName()
    {
        return Name + " " + LastName;
    }

    public string GetDocumentType()
    {
        return TypeDocument;
    }

    public string GetIdNumber()
    {
        return IdentificationNumber;
    }

    public int GetAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    public string GetPhoneNumber()
    {
        return PhoneNumber;
    }

    public string GetAddress()
    {
        return Address;
    }

    public string GetEmail()
    {
        return Email;
    }

    public string GetMembershipLevel()
    {
        return MembershipLevel;
    }

    public string GetPreferredPaymentMethod()
    {
        return PreferredPaymentMethod;
    }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdateLastName(string lastName)
    {
        LastName = lastName;
    }

    public void UpdateTypeDocument(string type)
    {
        TypeDocument = type;
    }

    public void UpdateIdentificationNumber(string identificationNumber)
    {
        IdentificationNumber = identificationNumber;
    }

    public void UpdateBirthDate(DateOnly birthDate)
    {
        BirthDate = birthDate;
    }

    public void UpdateEmail(string email)
    {
        Email = email;
    }

    public void UpdatePhoneNumber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    public void UpdateAddress(string address)
    {
        Address = address;
    }

    public void UpdateMembershipLevel(string membershipLevel)
    {
        MembershipLevel = membershipLevel;
    }

    public void UpdatePreferredPaymentMethod(string preferredPaymentMethod)
    {
        PreferredPaymentMethod = preferredPaymentMethod;
    }
}
