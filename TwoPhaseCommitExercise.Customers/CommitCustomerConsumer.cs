using MassTransit;
using TwoPhaseCommitExercise.Contracts.Coordinator;
using TwoPhaseCommitExercise.Contracts.Customers;
using TwoPhaseCommitExercise.Customers.Interfaces;

namespace TwoPhaseCommitExercise.Customers
{
    public class CommitCustomerConsumer : IConsumer<CommitCustomerTransaction>
    {
        private readonly ICustomerRepository repository;
        public CommitCustomerConsumer(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        public async Task Consume(ConsumeContext<CommitCustomerTransaction> context)
        {
            repository.Spend(context.Message.CustomerId, context.Message.Expenditure);
            repository.Unlock(context.Message.CustomerId);
            await context.RespondAsync<CommitAck>(new
            {
                Success = true
            });
        }
    }
}
