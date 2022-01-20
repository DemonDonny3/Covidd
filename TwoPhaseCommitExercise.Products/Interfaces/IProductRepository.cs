using TwoPhaseCommitExercise.Products.Models;

namespace TwoPhaseCommitExercise.Products.Interfaces
{
    public interface IProductRepository
    {
        public bool IsLocked(int customerId);
        public bool Lock(int customerId);
        public decimal Spend(int customerId, decimal expenditure);
    }
}
