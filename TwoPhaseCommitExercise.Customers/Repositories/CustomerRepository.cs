using TwoPhaseCommitExercise.Customers.Interfaces;
using TwoPhaseCommitExercise.Customers.Models;

namespace TwoPhaseCommitExercise.Customers.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> customers = new();
        public bool IsLocked(int customerId)
        {
            var customer = customers.Find(c => c.Id == customerId);
            if (customer is not null)
            {
                return customer.Locked;
            }
            throw new ArgumentException("Customer not found!");
        }

        public bool Lock(int customerId)
        {
            var customer = customers.Find(c => c.Id == customerId);
            if (customer is not null)
            {
                customer.Locked = true;
                return customer.Locked;
            }
            throw new ArgumentException("Customer not found!");
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
