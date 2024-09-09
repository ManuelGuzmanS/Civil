using Civil.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Civil.API.Controllers
{
    [ApiController]
    [Route("/api/patient")]
    public class PatientController:ControllerBase
    {
        private readonly DataContext dataContext;

        public PatientController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
