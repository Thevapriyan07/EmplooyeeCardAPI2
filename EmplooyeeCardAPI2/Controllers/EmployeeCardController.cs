using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmplooyeeCardAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeCardController : ControllerBase
    {
        [HttpGet]

        public async Task<ActionResult<List<EmployeeCard>>> GetEmployeeCards()
        {
            return new List<EmployeeCard>
            {
                new EmployeeCard
                {
                    Name = "Jack",
                    Firstname = "Manokaran",
                    Lastname = "Jadshan",
                    Place = "Jaffna"
                }
            };
        }
    }
}
