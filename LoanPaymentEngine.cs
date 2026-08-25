public record Installment(
    int Id,
    DateTime DueDate,
    decimal Penalty,
    decimal OverdueInterest,
    decimal CurrentInterest,
    decimal Principal
);

public class AllocationResult
{
    public decimal TotalPenaltyPaid { get; set; }
    public decimal TotalOverdueInterestPaid { get; set; }
    public decimal TotalCurrentInterestPaid { get; set; }
    public decimal TotalPrincipalPaid { get; set; }
    public decimal OverpaymentAdvance { get; set; }
    public List<Installment> RemainingInstallments { get; set; } = new();
}

public class LoanPaymentEngine
{
    public AllocationResult AllocatePayment(IEnumerable<Installment> installments, decimal paymentAmount)
    {
        var result = new AllocationResult();

        return result;
    }
}
