using crud_pets.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace crud_pets.Controllers
{
    [EnableCors(origins: "*", headers:"*", methods:"GET, POST, PUT, DELETE, OPTIONS")]
    public class PetController : ApiController
    {
        // GET: api/Pet
        public IEnumerable<Pet> Get()
        {
            PetManager petManager = new PetManager();
            return petManager.getPet();
        }

        // GET: api/Pet/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pet
        public bool Post([FromBody]Pet pet)
        {
            PetManager petManager = new PetManager();
            bool res = petManager.addPet(pet);

            return res;
        }

        // PUT: api/Pet/5
        public bool Put(int id, [FromBody]Pet pet)
        {
            PetManager petManager = new PetManager();
            bool res = petManager.updatePet(id, pet);
            return res;
        }

        // DELETE: api/Pet/5
        public bool Delete(int id)
        {
            PetManager petManager = new PetManager();
            bool res = petManager.deletePet(id);

            return res;
        }
    }
}
