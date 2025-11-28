using AutoMapper;
using BeautySalon.Entities;
using BeautySalon.Entities.Dto.Appointment;
using BeautySalon.Entities.Dto.Treatment;

namespace BeautySalon.Logic
{
    public class DtoProvider
    {
        public Mapper Mapper { get; }

        public DtoProvider()
        {
            Mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Treatment, TreatmentViewDto>();
                cfg.CreateMap<TreatmentCreateUpdateDto, Treatment>();


                cfg.CreateMap<Appointment, AppointmentViewDto>();
                cfg.CreateMap<AppointmentCreateUpdateDto, Appointment>();
            }));
        }
    }
}
