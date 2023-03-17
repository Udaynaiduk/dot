using Items.Entites;
using Items.service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Items.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private IItemservice itemservice;
        public ItemsController(IItemservice itemservice)
        {
            this.itemservice = itemservice;
        }

        // GET: api/<ItemsController>
        [HttpGet]
        public List<ItemDetails> Get()
        {
            return itemservice.GetItems();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ItemsController>
        [HttpPost]
        public IActionResult Post([FromBody] ItemDetails itemDetails)
        {
            if (itemservice.Add(itemDetails))
                return new OkObjectResult("Add Items Sucessfully");
            return new BadRequestObjectResult(itemDetails.ToString());



        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
