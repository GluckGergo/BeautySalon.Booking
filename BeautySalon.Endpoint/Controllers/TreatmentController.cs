using BeautySalon.Entities.Dto.Treatment;
using BeautySalon.Logic;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Endpoint.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class TreatmentController
    {
        TreatmentLogic logic;

        public TreatmentController(TreatmentLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<TreatmentViewDto> Get()
        {
            return logic.Read();
        }

        [HttpPost]
        public async Task Post(TreatmentCreateUpdateDto dto)
        {
            await logic.Create(dto);
        }

        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await logic.Delete(id);
        }

        [HttpPut("{id}")]
        public async Task Update(string id, [FromBody] TreatmentCreateUpdateDto dto)
        {
            await logic.Update(id, dto);
        }
    }
}
