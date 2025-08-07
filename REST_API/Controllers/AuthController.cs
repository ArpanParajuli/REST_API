using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using REST_API.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using REST_API.Services;


namespace REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IConfiguration _config;
        private readonly IAuthService _IAuthService;

        public AuthController(ApplicationDbContext applicationDbContext , IConfiguration config , IAuthService IAuthService)
        {
            _applicationDbContext = applicationDbContext;
            _config = config;
            _IAuthService =  IAuthService;
        }


        [HttpPost("login")]
        public  async Task<IActionResult> Login([FromBody] LoginReqDto obj)
        {

            var isValid = await _applicationDbContext.AuthUsers.FirstOrDefaultAsync(u => u.Email  == obj.Email);
            

            if(isValid == null || isValid.Password != obj.Password)
            {
                return NotFound();
            }


            var token = await _IAuthService.GenerateJwtToken(isValid);

            return Ok(token);
        }



        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterReqDto obj)
        {
            var Adduser = new AuthUser
            {
                UserName = obj.UserName,
                Role = obj.Role,
                Email = obj.Email,
                Password = obj.Password
            };

            await _applicationDbContext.AuthUsers.AddAsync(Adduser);

            await _applicationDbContext.SaveChangesAsync();

            return Ok("Register user");
        }


      

    }
}
