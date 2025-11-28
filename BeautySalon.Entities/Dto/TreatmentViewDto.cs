using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Entities.Dto
{
    public class TreatmentViewDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Time { get; set; }
        public IEnumerable<AppointmentViewInTreatmentDto>? Appointments { get; set; }
    }
}