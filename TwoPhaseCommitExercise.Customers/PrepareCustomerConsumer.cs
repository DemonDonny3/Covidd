using MassTransit;
using TwoPhaseCommitExercise.Contracts.Coordinator;
using TwoPhaseCommitExercise.Contracts.Customers;
using TwoPhaseCommitExercise.Customers.Interfaces;

namespace TwoPhaseCommitExercise.Customers
{
    public class PrepareCustomerConsumer : IConsumer<PrepareCustomerTransaction>
    {
        private readonly ICustomerRepository repository;
        public PrepareCustomerConsumer(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        public async Task Consume(ConsumeContext<PrepareCustomerTransaction> context)
        {
            if (repository.IsLocked(context.Message.CustomerId))
            {
                await context.RespondAsync<PrepareAck>(new
                {
                    Success = false
                });
            }
            else
            {
                repository.Lock(context.Message.CustomerId);
                await context.RespondAsync<PrepareAck>(new
                {
                    CustomerId = context.Message.CustomerId,
                    Success = true
                });
            }
        }
    }
}
