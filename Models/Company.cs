using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro.Models;

public class Company
{
    public static List<Driver> drivers = new List<Driver>();
    public static List<Customer> customers = new List<Customer>();
    public static List<Vehicle> vehicles = new List<Vehicle>();

    public static void AddDriver(Driver driver)
    {
        drivers.Add(driver);
    }

    public static void RemoveDriver(Driver driver)
    {
        drivers.Remove(driver);
    }

    public static void ShowDrivers()
    {
        Console.WriteLine("------------------------------------------------------------------------------------------");
        Console.WriteLine("|        Name        |     Id     | Age |   Phone    |  License  | Category | Experience |");
        Console.WriteLine("------------------------------------------------------------------------------------------");
        foreach (var driver in drivers)
        {
            var Name = driver.GetName();
            var IdNumber = driver.GetIdNumber();
            var Age = driver.GetAge();
            var PhoneNumber = driver.GetPhoneNumber();
            var LicenseNumber = driver.GetLicenseNumber();
            var LicenseCategory = driver.GetLicenseCategory();
            var DrivingExperience = driver.GetDrivingExperience();

            Console.WriteLine($"| {Name,-18} | {IdNumber,-10} | {Age,-3} | {PhoneNumber,-11}| {LicenseNumber} |    {LicenseCategory,-6}| {DrivingExperience,-5}años  |");
        }
        Console.WriteLine("------------------------------------------------------------------------------------------");
    }

    public static void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public static void RemoveVehicle(Vehicle vehicle)
    {
        vehicles.Remove(vehicle);
    }

    public static void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }

    public static void RemoveCustomer(Customer customer)
    {
        customers.Remove(customer);
    }
}
