using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;

namespace TwoPhaseCommitExercise.Contracts.Coordinator
{
    public class PrepareCustomerTransaction
    {
        public int CustomerId { get; set; }
        public int TransactionId { get; set; }
    }
}
