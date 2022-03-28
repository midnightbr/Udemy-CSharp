using System.Globalization;
using Exercicio008.Entities;
using Exercicio008.Entities.Services;

Console.WriteLine("Enter rental data");
Console.Write("Car model: ");
string model = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: $");
double hour = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: $");
double day = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);