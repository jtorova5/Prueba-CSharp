﻿using simulacro.Models;

var driver1 = new Driver("alberto", "buitrago", "cc", "1032456896", new DateOnly(1990, 10, 03), "albertobuitrago@gmail.com", "3007801458", "calle 15c #82bb 35", "123456987", "B2", 5);
var driver2 = new Driver("freddy", "guarin", "cc", "1024578596", new DateOnly(1980, 06, 04), "guarini@gmail.com", "3004596425", "calle 42 wallaby", "987456321", "A2", 10);
var driver3 = new Driver("esteban", "lopez", "cc", "1032456896", new DateOnly(1992, 04, 23), "lopez@gmail.com", "3005801458", "calle 15c #82bb 35", "123456987", "B2", 7);

Company.DriversList.Add(driver1);
Company.DriversList.Add(driver2);
Company.DriversList.Add(driver3);

var customer1 = new Customer("juan", "perez", "cc", "1012345678", new DateOnly(1995, 02, 15), "juanperez@gmail.com", "30098765432", "calle 32 #456 78", "silver", "debit card");
var customer2 = new Customer("marc", "quitos", "cc", "1024859634", new DateOnly(1997, 10, 17), "marquitos@gmail.com", "3146057896", "calle 28 #53b", "gold", "cash");

Company.CustomersList.Add(customer1);
Company.CustomersList.Add(customer2);

var vehicle1 = new Vehicle(1, "suv628", "car", "456987", "1112121", 5, driver1);
var vehicle2 = new Vehicle(2, "bmw789f", "motorcycle", "987654", "2223232", 2, driver2);
var vehicle3 = new Vehicle(3, "xhs435", "van", "456987", "1112", 7, driver3);

Company.VehiclesList.Add(vehicle1);
Company.VehiclesList.Add(vehicle2);
Company.VehiclesList.Add(vehicle3);

void getMenu()
{
    Console.Write(@"
Press any key to get into the menu.");
    Console.ReadKey();
    Menu();
}

void AddDriver()
{
    Console.Clear();
    Console.WriteLine("Add Driver");
    Console.WriteLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Last Name: ");
    string lastName = Console.ReadLine();
    Console.Write("Type Document: ");
    string typeDocument = Console.ReadLine();
    Console.Write("Identification Number: ");
    string identificationNumber = Console.ReadLine();
    Console.Write("Birth Date (yyyy-mm-dd): ");
    DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Phone Number: ");
    string phoneNumber = Console.ReadLine();
    Console.Write("Address: ");
    string address = Console.ReadLine();
    Console.Write("License Number: ");
    string licenseNumber = Console.ReadLine();
    Console.Write("License Category: ");
    string licenseCategory = Console.ReadLine();
    Console.Write("Driving Experience(years): ");
    int drivingExperience = int.Parse(Console.ReadLine());

    var driver = new Driver(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, licenseNumber, licenseCategory, drivingExperience);
    Company.AddDriver(driver);
    Console.WriteLine();
    Console.WriteLine($"Driver {name + " " + lastName} added successfully!");
}

void DeleteDriver()
{
    Console.WriteLine("Delete Driver");
    Console.WriteLine();
    Console.Write("Enter the driver's identification number: ");
    string identificationNumber = Console.ReadLine();

    var driver = Company.DriversList.Find(d => d.GetIdNumber() == identificationNumber);
    if (driver != null)
    {
        Company.RemoveDriver(driver);
        Console.Clear();
        Console.WriteLine($"Driver {driver.GetName()} deleted successfully!");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Driver not found.");
    }
}

void ShowDrivers()
{
    Company.ShowDrivers();
}

void UpdateDriver()
{
    Console.WriteLine("Update Driver");
    Console.WriteLine();
    Console.Write("Enter the driver's identification number: ");
    string identificationNumber = Console.ReadLine();
    Company.UpdateDriver(identificationNumber);
}

void AddCustomer()
{
    Console.Clear();
    Console.WriteLine("Add Customer");
    Console.WriteLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Last Name: ");
    string lastName = Console.ReadLine();
    Console.Write("Type Document: ");
    string typeDocument = Console.ReadLine();
    Console.Write("Identification Number: ");
    string identificationNumber = Console.ReadLine();
    Console.Write("Birth Date (yyyy-mm-dd): ");
    DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Phone Number: ");
    string phoneNumber = Console.ReadLine();
    Console.Write("Address: ");
    string address = Console.ReadLine();
    Console.Write("Membership Level: ");
    string membershipLevel = Console.ReadLine();
    Console.Write("Payment Method: ");
    string paymentMethod = Console.ReadLine();

    var customer = new Customer(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, membershipLevel, paymentMethod);
    Company.AddCustomer(customer);
    Console.WriteLine();
    Console.WriteLine($"Customer {name + " " + lastName} added successfully!");
}

void DeleteCustomer()
{
    Console.WriteLine("Delete Customer");
    Console.WriteLine();
    Console.Write("Enter the customer's identification number: ");
    string identificationNumber = Console.ReadLine();

    var customer = Company.CustomersList.Find(c => c.GetIdNumber() == identificationNumber);
    if (customer != null)
    {
        Company.RemoveCustomer(customer);
        Console.Clear();
        Console.WriteLine($"Customer {customer.GetName()} deleted successfully!");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Customer not found.");
    }
}

void ShowCustomers()
{
    Company.ShowCustomers();
}

void UpdateCustomer()
{
    Console.WriteLine("Update Customer");
    Console.WriteLine();
    Console.Write("Enter the customer's identification number: ");
    string identificationNumber = Console.ReadLine();
    Company.UpdateCustomer(identificationNumber);
}

void AddVehicle()
{
    Console.WriteLine("Add Vehicle");
    Console.WriteLine();
    Console.Write("Plate Number: ");
    string plateNumber = Console.ReadLine();
    Console.Write("Type: ");
    string type = Console.ReadLine();
    Console.Write("Engine Number: ");
    string engineNumber = Console.ReadLine();
    Console.Write("Serial Number: ");
    string serialNumber = Console.ReadLine();
    Console.Write("People Capacity: ");
    byte peopleCapacity = byte.Parse(Console.ReadLine());
    Console.Write("Driver Id number: ");
    int driverId = Convert.ToInt32(Console.ReadLine());
    var driver = Company.DriversList.Find(d => Convert.ToInt32(d.GetIdNumber()) == driverId);

    var vehicle = new Vehicle(plateNumber, type, engineNumber, serialNumber, peopleCapacity, driver);
    Company.AddVehicle(vehicle);
    Console.WriteLine();
    Console.WriteLine($"Vehicle with plate number {plateNumber} added successfully!");
}

void DeleteVehicle()
{
    Console.WriteLine("Delete Vehicle");
    Console.WriteLine();
    Console.Write("Enter the vehicle's Id: ");
    int vehicleId = int.Parse(Console.ReadLine());
    Vehicle.DeleteVehicle(vehicleId);
}

void ShowVehicles()
{
    Company.ShowVehicles();
}

void UpdateVehicle()
{
    Console.WriteLine("Update Vehicle");
    Console.WriteLine();
    Console.Write("Enter the vehicle's Id: ");
    int vehicleId = int.Parse(Console.ReadLine());
    Company.UpdateVehicle(vehicleId);
}

void Menu()
{
    Console.Clear();
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("|                 TransRiwi                |");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("| 1.  Add driver                           |");
    Console.WriteLine("| 2.  Delete driver                        |");
    Console.WriteLine("| 3.  Show drivers                         |");
    Console.WriteLine("| 4.  Update driver                        |");
    Console.WriteLine("| 5.  Add customer                         |");
    Console.WriteLine("| 6.  Delete customer                      |");
    Console.WriteLine("| 7.  Show customers                       |");
    Console.WriteLine("| 8.  Update customer                      |");
    Console.WriteLine("| 9.  Add vehicle                          |");
    Console.WriteLine("| 10. Delete vehicle                       |");
    Console.WriteLine("| 11. Show vehicles                        |");
    Console.WriteLine("| 12. Update vehicle                       |");
    Console.WriteLine("| 13. Users older than 30                  |");
    Console.WriteLine("| 14. Drivers ordered by experience (dec)  |");
    Console.WriteLine("| 15. Customers that pays with credit card |");
    Console.WriteLine("| 16. Drivers with 'A2' license            |");
    Console.WriteLine("| 17. Exit                                 |");
    Console.WriteLine("--------------------------------------------");
    Console.Write("Write the number of the option that you want: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Clear();
            AddDriver();
            getMenu();
            break;
        case 2:
            Console.Clear();
            ShowDrivers();
            DeleteDriver();
            getMenu();
            break;
        case 3:
            Console.Clear();
            ShowDrivers();
            getMenu();
            break;
        case 4:
            Console.Clear();
            ShowDrivers();
            UpdateDriver();
            getMenu();
            break;
        case 5:
            Console.Clear();
            AddCustomer();
            getMenu();
            break;
        case 6:
            Console.Clear();
            ShowCustomers();
            DeleteCustomer();
            getMenu();
            break;
        case 7:
            Console.Clear();
            ShowCustomers();
            getMenu();
            break;
        case 8:
            Console.Clear();
            ShowCustomers();
            UpdateCustomer();
            getMenu();
            break;
        case 9:
            Console.Clear();
            ShowDrivers();
            AddVehicle();
            getMenu();
            break;
        case 10:
            Console.Clear();
            ShowVehicles();
            DeleteVehicle();
            getMenu();
            break;
        case 11:
            Console.Clear();
            ShowVehicles();
            getMenu();
            break;
        case 12:
            Console.Clear();
            ShowVehicles();
            UpdateVehicle();
            getMenu();
            break;
        default:
            Console.WriteLine("Invalid option.");
            getMenu();
            break;
    }
}

Menu();