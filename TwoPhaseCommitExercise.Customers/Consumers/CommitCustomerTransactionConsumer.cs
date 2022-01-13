using MassTransit;
using TwoPhaseCommitExercise.Contracts.Coordinator;
using TwoPhaseCommitExercise.Customers.Interfaces;

namespace TwoPhaseCommitExercise.Customers.Consumers
{
    public class CommitCustomerTransactionConsumer : IConsumer<CommitCustomerTransaction>
    {
        private readonly ICustomerRepository _customerRepository;

        public CommitCustomerTransactionConsumer(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task Consume(ConsumeContext<CommitCustomerTransaction> context)
        {
            if (_customerRepository.IsLocked(context.Message.CustomerId))
            {

            }
        }
    }
}
