using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendly.Domain.Entities
{
    public class AttendanceRecord
    {
        public Guid Id { get; set; }
        public Guid AppUserId { get; set; }
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }

        public AppUser AppUser { get; set; }
    }

}
