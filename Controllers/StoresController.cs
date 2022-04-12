using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.DataAccess;
using api.Interfaces;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        // GET: api/Stores
        [HttpGet]
        public List<Store> Get()
        {
            List<Store> myStores = new List<Store>();
            IStoreDataHandler dataHandler = new StoreDataHandlerTest();
            myStores = dataHandler.GetAllStores();
            return myStores;
        
        }

        // GET: api/Stores/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stores
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stores/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Stores/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
