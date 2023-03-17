using Carts.Entities;
using Carts.Filters;
using Carts.service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog.Core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Carts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [CartActions]
  
    public class CartController : ControllerBase
    {
        private ICartService cartservice;
        ILogger log;

        public CartController(ICartService cartservice, ILogger<CartController> logger)
        {
            this.cartservice = cartservice;
            log = logger;
            logger.LogInformation("Cart added");



        }
        // GET: api/<CartController>
        [HttpGet]
        public IEnumerable<CartDetails> Get()
        {
            return cartservice.GetAll();
        }

        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CartController>
        [HttpPost]
        public IActionResult Post([FromBody] CartDto c)
        {
            var token = this.User;
            
            CartDetails cd = new CartDetails();
            cd.Email = this.User.FindFirst("UserId").Value;
            cd.Title = c.Title;
            cd.Price = c.Price;
            cd.qty = c.qty;
            cd.Value = c.Price * c.qty;
            if (cartservice.Insert(cd))
                return new OkObjectResult("Successfully");
            return new BadRequestObjectResult(c.ToString());
        }

        // PUT api/<CartController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
