namespace Exercicio008.Entities.Services; 

public class RentalService {
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }
    
    private ITaxService _taxService;

    // Inversão de controle por injeção de dependencia
    public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) {
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
        _taxService = taxService;
    }

    public void ProcessInvoice(CarRental carRental) {
        TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
        double basicPayment = 0.0;

        if (duration.TotalHours <= 12.00) {
            basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); // Math.Ceiling arrendonda para cima
        }
        else {
            basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
        }

        double tax = _taxService.Tax(basicPayment);

        carRental.Invoice = new Invoice(basicPayment, tax);
    }
}
