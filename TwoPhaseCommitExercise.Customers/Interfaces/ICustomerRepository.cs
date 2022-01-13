using TwoPhaseCommitExercise.Customers.Models;

namespace TwoPhaseCommitExercise.Customers.Interfaces
{
    public interface ICustomerRepository
    {
        public bool IsLocked(int customerId);
        public bool Lock(int customerId);
        public bool Spend(int customerId, decimal expenditure);
    }
}
