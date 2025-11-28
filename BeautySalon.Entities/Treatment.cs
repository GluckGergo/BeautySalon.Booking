using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Entities
{
    public class Treatment : IIdEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [StringLength(250)]
        public string Name { get; set; } = string.Empty;
        public int Time { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
