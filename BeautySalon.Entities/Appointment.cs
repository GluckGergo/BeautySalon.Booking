using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Entities
{
    public class Appointment : IIdEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime Date { get; set; }
        public string TreatmentId { get; set; } = string.Empty;

        [NotMapped]
        public Treatment? Treatment { get; set; }
    }
}
