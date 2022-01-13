using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPhaseCommitExercise.Contracts.Coordinator
{
    public class CommitCustomerTransaction
    {
        public int CustomerId { get; set; }
        public int TransactionId { get; set; }
        public decimal Expenditure { get; set; }
    }
}
