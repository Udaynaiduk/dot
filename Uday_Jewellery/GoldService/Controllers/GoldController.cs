using GoldService.Entites;
using GoldService.Repository;
using GoldService.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GoldService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoldController : ControllerBase
    {
       IGoldService1 repo;
        public GoldController(IGoldService1 repo)
        {
            this.repo = repo;
        }
        // GET: api/<GoldController>
        [HttpGet]
        public IEnumerable<GoldOrnment> Get()
        {
            return this.repo.GetAll();
        }

        // GET api/<GoldController>/5
        [HttpGet("{id}")]
        public GoldOrnment Get(int id)
        {
            return this.repo.ById(id);
        }

        // POST api/<GoldController>
        [HttpPost]
        public void Post([FromBody] GoldOrnment go )
        {
            this.repo.Add(go);
        }

        // PUT api/<GoldController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GoldOrnment go)
        {
            this.repo.Modify(id, go);
        }

        // DELETE api/<GoldController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.repo.Remove(id);
        }
    }
}
