using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace simulacro.Models;

public class Company
{
    public static List<Driver> DriversList = new List<Driver>();
    public static List<Customer> CustomersList = new List<Customer>();
    public static List<Vehicle> VehiclesList = new List<Vehicle>();

    public static void AddDriver(Driver driver)
    {
        DriversList.Add(driver);
    }

    public static void RemoveDriver(Driver driver)
    {
        DriversList.Remove(driver);
    }

    public static void UpdateDriver(string idNumber)
    {
        var driver = DriversList.Find(d => d.GetIdNumber() == idNumber);
        if (driver != null)
        {
            Console.Clear();
            Console.WriteLine("Update Driver");
            Console.WriteLine();
            Console.Write("Enter the new name: ");
            var newName = Console.ReadLine();
            driver.UpdateName(newName);
            Console.Write("Enter the new last name: ");
            var newLastName = Console.ReadLine();
            driver.UpdateLastName(newLastName);
            Console.Write("Enter the new type document: ");
            var newTypeDocument = Console.ReadLine();
            driver.UpdateTypeDocument(newTypeDocument);
            Console.Write("Enter the new identification number: ");
            var newIdNumber = Console.ReadLine();
            driver.UpdateIdentificationNumber(newIdNumber);
            Console.Write("Enter the new email: ");
            var newEmail = Console.ReadLine();
            driver.UpdateEmail(newEmail);
            Console.Write("Enter the new phone number: ");
            var newPhoneNumber = Console.ReadLine();
            driver.UpdatePhoneNumber(newPhoneNumber);
            Console.Write("Enter the new address: ");
            var newAddress = Console.ReadLine();
            driver.UpdateAddress(newAddress);
            Console.Write("Enter the new license number: ");
            var newLicenseNumber = Console.ReadLine();
            driver.UpdateLicenseNumber(newLicenseNumber);
            Console.Write("Enter the new license category: ");
            var newCategory = Console.ReadLine();
            driver.UpdateLicenseCategory(newCategory);
            Console.Write("Enter the new number of years of driving experience: ");
            var newExperience = int.Parse(Console.ReadLine());
            driver.UpdateDrivingExperience(newExperience);
            Console.Clear();
            Console.WriteLine($"Driver with Id: {idNumber} updated successfully!");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Driver not found.");
        }
    }

    public static void ShowDrivers()
    {
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("|        Name        |     Id     | Age |   Phone    |  License  | Category | Experience |");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        foreach (var driver in DriversList)
        {
            var Name = driver.GetName();
            var IdNumber = driver.GetIdNumber();
            var Age = driver.GetAge();
            var PhoneNumber = driver.GetPhoneNumber();
            var LicenseNumber = driver.GetLicenseNumber();
            var LicenseCategory = driver.GetLicenseCategory();
            var DrivingExperience = driver.GetDrivingExperience();

            Console.WriteLine($"| {Name,-18} | {IdNumber,-10} | {Age,-3} | {PhoneNumber,-11}| {LicenseNumber,-8} |    {LicenseCategory,-6}| {DrivingExperience,-5}años  |");
        }
        Console.WriteLine("------------------------------------------------------------------------------------------");
    }

    public static void AddCustomer(Customer customer)
    {
        CustomersList.Add(customer);
    }

    public static void RemoveCustomer(Customer customer)
    {
        CustomersList.Remove(customer);
    }

    public static void UpdateCustomer(string idNumber)
    {
        var customer = CustomersList.Find(c => c.GetIdNumber() == idNumber);
        if (customer != null)
        {
            Console.Clear();
            Console.WriteLine("Update Customer");
            Console.WriteLine();
            Console.Write("Enter the new name: ");
            var newName = Console.ReadLine();
            customer.UpdateName(newName);
            Console.Write("Enter the new last name: ");
            var newLastName = Console.ReadLine();
            customer.UpdateLastName(newLastName);
            Console.Write("Enter the new type document: ");
            var newTypeDocument = Console.ReadLine();
            customer.UpdateTypeDocument(newTypeDocument);
            Console.Write("Enter the new identification number: ");
            var newIdNumber = Console.ReadLine();
            customer.UpdateIdentificationNumber(newIdNumber);
            Console.Write("Enter the new email: ");
            var newEmail = Console.ReadLine();
            customer.UpdateEmail(newEmail);
            Console.Write("Enter the new phone number: ");
            var newPhoneNumber = Console.ReadLine();
            customer.UpdatePhoneNumber(newPhoneNumber);
            Console.Write("Enter the new address: ");
            var newAddress = Console.ReadLine();
            customer.UpdateAddress(newAddress);
            Console.Write("Enter the new membership level: ");
            var newMembershipLevel = Console.ReadLine();
            customer.UpdateMembershipLevel(newMembershipLevel);
            Console.Write("Enter the new preferred payment method: ");
            var newPreferredPaymentMethod = Console.ReadLine();
            customer.UpdatePreferredPaymentMethod(newPreferredPaymentMethod);
            Console.Clear();
            Console.WriteLine($"Customer with Id: {idNumber} updated successfully!");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Customer not found.");
        }
    }

    public static void ShowCustomers()
    {
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("|        Name        |     Id     | Age |    Phone    |         Email        | Phone Number |          Address          |  Payment method  |");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
        foreach (var customer in CustomersList)
        {
            var Name = customer.GetName();
            var IdNumber = customer.GetIdNumber();
            var Age = customer.GetAge();
            var PhoneNumber = customer.GetPhoneNumber();
            var Email = customer.GetEmail();
            var PhoneNumberCustomer = customer.GetPhoneNumber();
            var Address = customer.GetAddress();
            var CreditCardType = customer.GetPreferredPaymentMethod();

            Console.WriteLine($"| {Name,-18} | {IdNumber,-10} | {Age,-3} | {PhoneNumber,-12}| {Email,-20} | {PhoneNumberCustomer,-13}| {Address,-25} | {CreditCardType,-17}|");
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
    }

    public static void AddVehicle(Vehicle vehicle)
    {
        VehiclesList.Add(vehicle);
    }

    public static void RemoveVehicle(Vehicle vehicle)
    {
        VehiclesList.Remove(vehicle);
    }

    public static void UpdateVehicle(int id)
    {
        var vehicle = VehiclesList.Find(v => v.Id == id);
        if (vehicle != null)
        {
            Console.Clear();
            Console.WriteLine("Update Vehicle");
            Console.WriteLine();
            Console.Write("Enter the new plate number: ");
            var newPlateNumber = Console.ReadLine();
            vehicle.CarPlate = newPlateNumber;
            Console.Write("Enter the new type: ");
            var newType = Console.ReadLine();
            vehicle.Type = newType;
            Console.Write("Enter the new engine number: ");
            var newEngineNumber = Console.ReadLine();
            vehicle.EngineNumber = newEngineNumber;
            Console.Write("Enter the new serial number: ");
            var newSerialNumber = Console.ReadLine();
            vehicle.SerialNumber = newSerialNumber;
            Console.Write("Enter the new capacity: ");
            var newPeopleCapacity = byte.Parse(Console.ReadLine());
            vehicle.PeopleCapacity = newPeopleCapacity;
            Console.Clear();
            Company.ShowDrivers();
            Console.Write("Enter the new owner's Id number: ");
            var newOwnerId = int.Parse(Console.ReadLine());
            var newOwner = DriversList.Find(d => Convert.ToInt32(d.GetIdNumber()) == newOwnerId);
            vehicle.Owner = newOwner;
        }
    }

    public static void ShowVehicles()
    {
        Console.WriteLine("-----------------------------------------------------------------------------------------------");
        Console.WriteLine("| Id |Plate Number|    Type    | Engine Number | Serial Number | Capacity |       Owner       |");
        Console.WriteLine("-----------------------------------------------------------------------------------------------");

        foreach (var vehicle in VehiclesList)
        {
            var Id = vehicle.Id;
            var PlateNumber = vehicle.CarPlate;
            var Type = vehicle.Type;
            var EngineNumber = vehicle.EngineNumber;
            var SerialNumber = vehicle.SerialNumber;
            var PeopleCapacity = vehicle.PeopleCapacity;
            var Owner = vehicle.Owner.GetName();

            Console.WriteLine($"| {Id,-2} |   {PlateNumber,-8} | {Type,-10} | {EngineNumber,-13} | {SerialNumber,-13} |    {PeopleCapacity,-5} | {Owner,-18}|");
        }
        Console.WriteLine("-----------------------------------------------------------------------------------------------");
    }

    public static int IdAuto()
    {
        var validateVehicle = VehiclesList;
        var IdCount = VehiclesList.Count() + 1;
        if (validateVehicle.Last().Id == IdCount)
        {
            return IdCount + 1;
        }
        else
        {
            return IdCount;
        }
    }
}
