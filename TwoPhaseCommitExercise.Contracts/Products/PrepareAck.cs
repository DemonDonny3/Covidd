using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPhaseCommitExercise.Contracts.Products
{
    public class PrepareAck
    {
        public int ProductId { get; set; }
        public bool Success { get; set; }
    }
}
