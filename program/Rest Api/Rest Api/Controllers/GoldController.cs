using Microsoft.AspNetCore.Mvc;
using Rest_Api.Controllers.GoldRepositroy;
using Rest_Api.Entites;
using Rest_Api.Repositroy;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rest_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GoldController : ControllerBase
    {
        private IGoldRepository repository;
        public GoldController(IGoldRepository repo)
        {
            repository = repo;
        }

        // GET: api/<GoldController>
        [HttpGet]
        public IEnumerable<GoldOrnment> Get()
        {
            return repository.display();
        }

        // GET api/<GoldController>/5
        [HttpGet("{id}")]
        public GoldOrnment Get(int id)
        {
            return  repository.getbyid(id);
        }

        // POST api/<GoldController>
        [HttpPost]
        public void Post([FromBody] GoldOrnment  go)
        {
            repository.Add(go);
            
        }

        // PUT api/<GoldController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GoldOrnment go)
        {
            bool status=repository.update(id,go);

        }

        // DELETE api/<GoldController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.delete(id);
        }

        [HttpGet()]
        [Route("Price")]
        public IEnumerable<GoldOrnment> Get(double price)
        {
            // return new List<GoldOrnment>(repository.display());
            return new List<GoldOrnment> { new GoldOrnment() { Id=100} };
        }
    }
}
