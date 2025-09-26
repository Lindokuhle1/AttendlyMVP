using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendly.Domain.Entities
{
    public class Sale
    {
        public Guid Id { get; set; }
        public Guid POSItemId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid TenantId { get; set; }
    }
}
