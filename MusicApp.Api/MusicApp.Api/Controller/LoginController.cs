using Microsoft.AspNetCore.Mvc;
using MusicApp.Api.Model;

namespace MusicApp.Api.Controller
{

    [ApiController]
    [Route("[controller]")]

    public class LoginController : ControllerBase
    {
        private readonly String _connectionString;
     
        public LoginController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MusicApp");
        }

    }
}
