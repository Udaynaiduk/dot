using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using Seller.Entites;
using Seller.Service;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Seller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private IVendorservice vendorservice;
        private IConfiguration config;
        public VendorController(IVendorservice vendorservice, IConfiguration config)
        {
            this.vendorservice = vendorservice;
            this.config = config;
        }
        // GET: api/<VCoendorntroller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VCoendorntroller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VCoendorntroller>
        [HttpPost]
        [Route("Register")]
        public IActionResult Post([FromBody] Vendor vendor)
        {
            if(vendorservice.Add(vendor))
                return new OkObjectResult("Add seller");
            return new BadRequestObjectResult(vendor.ToString());
        }
        [HttpPost]
        [Route("Validate")]
        public IActionResult Validate([FromBody] Vendor vendor)
        {
            if (vendorservice.Login(vendor))
            {
                string t = GenerateJSONWebToken(vendor);
                var obj = new token() { sucess = true, result = t };
                return new OkObjectResult(obj);
            }
            return new BadRequestObjectResult(vendor.ToString());
        }
        private string GenerateJSONWebToken(Vendor us)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim("email",us.Email),
                new Claim("password",us.Password),
            };
            var token = new JwtSecurityToken(config["Jwt:Issuer"],
            config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }



        // PUT api/<VCoendorntroller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VCoendorntroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
public class token
{

    public bool sucess { get; set; }
    public string? result { get; set; }
}