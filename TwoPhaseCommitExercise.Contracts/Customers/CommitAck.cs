using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPhaseCommitExercise.Contracts.Customers
{
    public class CommitAck
    {
        public bool Success { get; set; }

    }
}
