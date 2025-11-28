using BeautySalon.Entities.Dto.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Entities.Dto.Appointment
{
    public class AppointmentViewDto
    {
        public string Id { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string TreatmentId { get; set; } = string.Empty;
        public TreatmentViewInAppointmentDto? Treatment { get; set; }
    }
}
