using MassTransit;
using TwoPhaseCommitExercise.Contracts.Coordinator;
using TwoPhaseCommitExercise.Customers.Interfaces;

namespace TwoPhaseCommitExercise.Customers.Consumers
{
    public class PrepareCustomerTransactionConsumer : IConsumer<PrepareCustomerTransaction>
    {
        private readonly IPublishEndpoint _endpoint;
        private readonly ICustomerRepository _customers;

        public PrepareCustomerTransactionConsumer(ICustomerRepository customers, IPublishEndpoint endpoint)
        {
            _customers = customers;
            _endpoint = endpoint;
        }

        public Task Consume(ConsumeContext<PrepareCustomerTransaction> context)
        {
            if (_customers.IsLocked(context.Message.CustomerId))
            {
                _endpoint.Publish<>
            }
        }
    }
}
