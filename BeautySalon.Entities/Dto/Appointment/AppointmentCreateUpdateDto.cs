using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Entities.Dto.Appointment
{
    public class AppointmentCreateUpdateDto
    {
        public DateTime Date { get; set; }
        public string TreatmentId { get; set; } = string.Empty;
    }
}
