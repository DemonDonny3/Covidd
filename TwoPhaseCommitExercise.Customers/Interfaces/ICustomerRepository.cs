using TwoPhaseCommitExercise.Customers.Models;

namespace TwoPhaseCommitExercise.Customers.Interfaces
{
    public interface ICustomerRepository
    {
        public bool IsLocked(int customerId);
        public void Lock(int customerId);
        public void Unlock(int customerId);
        public decimal Spend(int customerId, decimal expenditure);
    }
}
