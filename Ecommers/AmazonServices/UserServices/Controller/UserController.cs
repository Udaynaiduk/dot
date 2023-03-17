using Microsoft.AspNetCore.Mvc;
using UserServices.Entites;
using UserServices.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserServices.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserS repo;
        public UserController(IUserS repo)
        {
            this.repo = repo;
        }
        // GET: api/<UserController>
        [HttpGet]
        public List<User> Get()
        {
            return this.repo.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("Register")]
        public IActionResult Post([FromBody] User us)
        {
            if (repo.Add(us))

                return new OkObjectResult("AddUser");
           return new BadRequestObjectResult(us.ToString());
           
        }

        // PUT api/<UserController>/5
        [HttpPost]
        [Route("Validate")]
        public IActionResult Validate([FromBody]User us)
        {
            if (repo.validate(us))
            
                return new OkObjectResult("Validate sucess");
            
            return new BadRequestObjectResult(us.ToString());

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
