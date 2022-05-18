namespace ExProp_34.Entities.Services;

public interface IOnlinePaymentService {
    double PaymentFee(double amount);
    double Interest(double amount, int months);
}
