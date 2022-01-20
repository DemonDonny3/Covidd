using TwoPhaseCommitExercise.Customers.Interfaces;
using TwoPhaseCommitExercise.Customers.Models;

namespace TwoPhaseCommitExercise.Customers.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> customers = new();
        private readonly HashSet<int> lockedCustomers = new();
        public bool IsLocked(int customerId)
        {
            return lockedCustomers.Contains(customerId);
        }

        public void Lock(int customerId)
        {
            lockedCustomers.Add(customerId);
        }

        public void Unlock(int customerId)
        {
            lockedCustomers.Remove(customerId);
        }

        public decimal Spend(int customerId, decimal expenditure)
        {
            var customer = customers.Find(c => c.Id == customerId);
            if (customer is null) throw new ArgumentException("Customer not found!");
            if (customer.Funds < expenditure) throw new ArgumentException("Funds insufficient");

            customer.Funds -= expenditure;
            return customer.Funds;            
        }
    }
}
