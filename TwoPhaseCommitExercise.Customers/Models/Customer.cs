namespace TwoPhaseCommitExercise.Customers.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public decimal Funds { get; set; }
        public bool Locked { get; set; } = false;
        public int TransactionId { get; set; }
    }
}
