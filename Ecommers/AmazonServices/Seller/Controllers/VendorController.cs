using Microsoft.AspNetCore.Mvc;
using Seller.Entites;
using Seller.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Seller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private IVendorservice vendorservice;
        public VendorController(IVendorservice vendorservice)
        {
            this.vendorservice = vendorservice;
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
                return new OkObjectResult("Add seller");
            return new BadRequestObjectResult(vendor.ToString());
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
