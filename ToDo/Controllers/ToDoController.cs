using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Model;
using ToDo.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDo.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<ToDo.Model.ToDo> Get()
        {
            IToDoRepository repo = new ToDoRepository();
            return repo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ToDo.Model.ToDo Get(int id)
        {
            IToDoRepository repo = new ToDoRepository();
            return repo.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
