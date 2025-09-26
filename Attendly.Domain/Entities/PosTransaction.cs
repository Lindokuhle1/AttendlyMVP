using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendly.Domain.Entities
{
    public class PosTransaction
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
