using System.Globalization;
using ExProp_34.Entities;
using ExProp_34.Entities.Services;

Console.WriteLine("Enter contract data:");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/mm/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: R$");
double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract myContract = new Contract(number, date, value);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(myContract, months);

Console.WriteLine("Installments:");
foreach (Installment installment in myContract.Installments) {
    Console.WriteLine(installment);
}