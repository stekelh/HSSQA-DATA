using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QAData.Models
{
    public class QACard
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public DateTime Created { get; set; }
        public virtual IEnumerable<Checkouts> Checkout { get; set; }
    }
}
