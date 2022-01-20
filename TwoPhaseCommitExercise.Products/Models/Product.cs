namespace TwoPhaseCommitExercise.Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool Locked { get; set; } = false;
        public int TransactionId { get; set; }
    }
}
