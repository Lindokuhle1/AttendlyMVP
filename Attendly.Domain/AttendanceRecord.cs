using Attendly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendly.Domain
{
    public class AttendanceRecord
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public ClockType ClockType { get; set; }
        public Guid TenantId { get; set; }
    }
}
