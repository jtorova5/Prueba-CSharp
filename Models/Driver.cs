using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro.Models;

public class Driver : User
{
    public string LicenseNumber { get; set; }
    public string LicenseCategory { get; set; }
    public int DrivingExperience { get; set; }

    public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string licenseNumber, string licenseCategory, int drivingExperience) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
    {
        LicenseNumber = licenseNumber;
        LicenseCategory = licenseCategory;
        DrivingExperience = drivingExperience;
    }

    public void UpdateLicenseCategory(string newCategory)
    {
        LicenseCategory = newCategory;
    }

    public void AddExperience(int years)
    {
        DrivingExperience += years;
    }

    public string GetName()
    {
        return Name + " " + LastName;
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

    public string GetLicenseNumber()
    {
        return LicenseNumber;
    }

    public string GetLicenseCategory()
    {
        return LicenseCategory;
    }

    public int GetDrivingExperience()
    {
        return DrivingExperience;
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

    public void UpdateLicenseNumber(string licenseNumber)
    {
        LicenseNumber = licenseNumber;
    }

    public void UpdateDrivingExperience(int drivingExperience)
    {
        DrivingExperience = drivingExperience;
    }


}
