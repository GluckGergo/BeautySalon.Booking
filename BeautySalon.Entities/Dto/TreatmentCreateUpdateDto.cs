using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Entities.Dto
{
    public class TreatmentCreateUpdateDto
    {
        public string Name { get; set; } = string.Empty;
        public int Time { get; set; }
    }
}
