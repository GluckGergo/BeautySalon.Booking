using AutoMapper;
using BeautySalon.Data;
using BeautySalon.Entities;
using BeautySalon.Entities.Dto.Appointment;
using BeautySalon.Entities.Dto.Treatment;

namespace BeautySalon.Logic
{
    public class TreatmentLogic
    {
        public Repository<Treatment> repository;
        public Mapper mapper;

        public TreatmentLogic(Repository<Treatment> repository, DtoProvider provider)
        {
            this.repository = repository;
            this.mapper = provider.Mapper;
        }

        public IEnumerable<TreatmentViewDto> Read()
        {
            return repository.GetAll().Select(t => mapper.Map<TreatmentViewDto>(t));
        }
        public async Task Create(TreatmentCreateUpdateDto dto)
        {

            var treatment = mapper.Map<Treatment>(dto);
            await repository.CreateAsync(treatment);
        }
        public async Task Delete(string id)
        {
            await repository.DeleteByIdAsync(id);
        }

        public async Task Update(string id, TreatmentCreateUpdateDto dto)
        {
            var movieToUpdate = repository.FindById(id);
            if (movieToUpdate != null)
            {
                mapper.Map(dto, movieToUpdate);
                await repository.UpdateAsync(movieToUpdate);
            }
        }
    }
}
