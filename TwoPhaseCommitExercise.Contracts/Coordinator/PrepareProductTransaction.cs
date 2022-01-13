using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPhaseCommitExercise.Contracts.Coordinator
{
    public class PrepareProductTransaction
    {
        public int ProductId { get; set; }
        public int TransactionId { get; set; }
    }
}
