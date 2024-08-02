using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            Console.WriteLine($"| {Name,-18} | {IdNumber,-10} | {Age,-3} | {PhoneNumber,-11}| {LicenseNumber, -8} |    {LicenseCategory,-6}| {DrivingExperience,-5}años  |");
        }
        Console.WriteLine("------------------------------------------------------------------------------------------");
    }

    public static void AddVehicle(Vehicle vehicle)
    {
        VehiclesList.Add(vehicle);
    }

    public static void RemoveVehicle(Vehicle vehicle)
    {
        VehiclesList.Remove(vehicle);
    }

    public static void AddCustomer(Customer customer)
    {
        CustomersList.Add(customer);
    }

    public static void RemoveCustomer(Customer customer)
    {
        CustomersList.Remove(customer);
    }
}
