using BeautySalon.Entities.Dto.Appointment;
using BeautySalon.Logic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BeautySalon.Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : ControllerBase
    {
        AppointmentLogic logic;

        public AppointmentController(AppointmentLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<AppointmentViewDto> Get()
        {
            return logic.Read();
        }

        [HttpPost]
        [Authorize]
        public async Task Post(AppointmentCreateUpdateDto dto)
        {
            await logic.Create(dto);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task Delete(string id)
        {
            await logic.Delete(id);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task Update(string id, [FromBody] AppointmentCreateUpdateDto dto)
        {
            await logic.Update(id, dto);
        }
    }
}
