using CityGuide.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace CityGuide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        DataContext _context;
        protected UsersController(DataContext context)
        {
            _context = context;
        }
    }
}