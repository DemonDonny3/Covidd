using TwoPhaseCommitExercise.Customers.Interfaces;
using TwoPhaseCommitExercise.Customers.Models;

namespace TwoPhaseCommitExercise.Customers.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private List<Customer> customers = new List<Customer>();
        public bool IsLocked(int customerId)
        {
            var customer = customers.Find(c => c.Id == customerId);
            if (customer is not null)
            {
                return customer.Locked;
            }
            throw new ArgumentException();
        }

        public bool Lock(int customerId)
        {
            throw new NotImplementedException();
        }

        public bool Spend(int customerId, decimal expenditure)
        {
            throw new NotImplementedException();
        }
    }
}
