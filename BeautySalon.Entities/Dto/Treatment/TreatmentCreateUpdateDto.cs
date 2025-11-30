using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Entities.Dto.Treatment
{
    public class TreatmentCreateUpdateDto
    {
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Range(5, 120)]
        public int Time { get; set; }
    }
}
