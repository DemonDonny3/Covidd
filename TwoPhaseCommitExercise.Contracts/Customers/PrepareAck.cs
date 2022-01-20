using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPhaseCommitExercise.Contracts.Customers
{
    public class PrepareAck
    {
        public int CustomerId { get; set; }
        public bool Success { get; set; }
    }
}
