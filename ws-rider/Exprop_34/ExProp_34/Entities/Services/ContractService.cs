namespace ExProp_34.Entities.Services; 

public class ContractService {
    private IOnlinePaymentService _onlinePayment;

    public ContractService(IOnlinePaymentService onlinePayment) {
        _onlinePayment = onlinePayment;
    }

    // Regra de negocio
    public void ProcessContract(Contract contract, int months) {
        // Valor base de cada mensalidade
        double basicValueQuota = contract.TotalValue / months;
        for (int i = 1; i <= months; i++) {
            double updateQuota = basicValueQuota + _onlinePayment.Interest(basicValueQuota, i); // Valor parcial
            double fullQuota = updateQuota + _onlinePayment.PaymentFee(updateQuota); // Valor final da mensalidade
            DateTime date = contract.Date.AddMonths(i); // Adicionando os meses
            contract.AddInstallment(new Installment(date, fullQuota));
        }

    }
}
