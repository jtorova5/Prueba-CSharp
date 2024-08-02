using simulacro.Models;

var driver1 = new Driver("alberto", "buitrago", "cc", "1032456896", new DateOnly(1990, 10, 03), "albertobuitrago@gmail.com", "3007801458", "calle 15c #82bb 35", "123456987", "B2", 5);
var driver2 = new Driver("freddy", "guarin", "cc", "1024578596", new DateOnly(1980, 06, 04), "guarini@gmail.com", "30045896425", "calle 42 wallaby", "987456321", "A2", 10);
var driver3 = new Driver("esteban", "lopez", "cc", "1032456896", new DateOnly(1992, 04, 23), "lopez@gmail.com", "3005801458", "calle 15c #82bb 35", "123456987", "B2", 7);

Company.drivers.Add(driver1);
Company.drivers.Add(driver2);
Company.drivers.Add(driver3);

var customer1 = new Customer("juan", "perez", "cc", "1012345678", new DateOnly(1995, 02, 15), "juanperez@gmail.com", "30098765432", "calle 32 #456 78", "silver", "debit card");
var customer2 = new Customer("marc", "quitos", "cc", "1024859634", new DateOnly(1997, 10, 17), "marquitos@gmail.com", "3146057896", "calle 28 #53b", "gold", "cash");

Company.customers.Add(customer1);
Company.customers.Add(customer2);

var vehicle1 = new Vehicle(1,"suv628","car","456987","1112121",5,driver1);
var vehicle2 = new Vehicle(2,"bmw789f","motorcycle","987654","2223232",2,driver2);
var vehicle3 = new Vehicle(3,"xhs435","van","456987","1112",7,driver3);

Company.vehicles.Add(vehicle1);
Company.vehicles.Add(vehicle2);
