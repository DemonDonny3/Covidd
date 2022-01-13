using MassTransit;
using TwoPhaseCommitExercise.Contracts.Coordinator;
using TwoPhaseCommitExercise.Customers.Interfaces;

namespace TwoPhaseCommitExercise.Customers.Consumers
{
    public class CommitCustomerTransactionConsumer : IConsumer<CommitCustomerTransaction>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IPublishEndpoint _publishEndpoint;

        public CommitCustomerTransactionConsumer(ICustomerRepository customerRepository, IPublishEndpoint publishEndpoint)
        {
            _customerRepository = customerRepository;
            _publishEndpoint = publishEndpoint;
        }

        public async Task Consume(ConsumeContext<CommitCustomerTransaction> context)
        {
            if (_customerRepository.IsLocked(context.Message.CustomerId))
            {
                _publishEndpoint.Publish
            }
        }
    }
}
