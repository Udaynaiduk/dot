using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserServices.Entites;
using UserServices.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserServices.Controller
{
    [Route("api/[controller]")]//add route function
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserS repo;
        private IConfiguration config;
        public UserController(IUserS repo,IConfiguration config)//constructor with parameter
        {
            this.repo = repo;
            this.config = config;
        }
        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            return this.repo.GetAll();
        }

        // GET api/<UserController>/{id}
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>/Register
        [HttpPost]
        [Route("Register")]
        public IActionResult Post([FromBody] User us)
        {
            if (repo.Add(us))

                return new OkObjectResult("AddUser");
           return new BadRequestObjectResult(us.ToString());
           
        }

        // PUT api/<UserController>/Validate
        [HttpPost]
        [Route("Validate")]
        public IActionResult Validate([FromBody]User us)
        {
            if (repo.validate(us))
            {
                string t = GenerateJSONWebToken(us);
                var obj = new token() { sucess =true, result = t };
                return new OkObjectResult(obj);
            }
            return new BadRequestObjectResult(us.ToString());

        }
        //creating a json web token
        private string GenerateJSONWebToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var credentials=new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim("UserId",user.Email),
                new Claim("password",user.Password),
            };
            var token = new JwtSecurityToken(config["Jwt:Issuer"],
            config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // DELETE api/<UserController>/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
public class token{

 public   bool sucess { get; set; }
   public      string? result { get; set; }
}