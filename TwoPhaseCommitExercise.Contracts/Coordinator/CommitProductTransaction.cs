using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPhaseCommitExercise.Contracts.Coordinator
{
    public class CommitProductTransaction
    {
        public int ProductId { get; set; }
        public int TransactionId { get; set; }
        public int Quantity { get; set; }
    }
}
