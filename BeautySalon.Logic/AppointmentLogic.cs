using AutoMapper;
using BeautySalon.Data;
using BeautySalon.Entities;
using BeautySalon.Entities.Dto.Appointment;

namespace BeautySalon.Logic
{
    public class AppointmentLogic
    {
        public Repository<Appointment> repository;
        public Mapper mapper;

        public AppointmentLogic(Repository<Appointment> repository, DtoProvider provider)
        {
            this.repository = repository;
            this.mapper = provider.Mapper;
        }

        public IEnumerable<AppointmentViewDto> Read()
        {
            return repository.GetAll().Select(t => mapper.Map<AppointmentViewDto>(t));
        }
        public async Task Create(AppointmentCreateUpdateDto dto)
        {

            var movie = mapper.Map<Appointment>(dto);
            await repository.CreateAsync(movie);
        }
    }
}
