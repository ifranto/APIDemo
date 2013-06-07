using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Data;

namespace API.WebAPI.Controllers
{
    public class SessionController : ApiController
    {
        // GET api/session
        public IEnumerable<Session> Get()
        {
            return SessionRepository.All();
        }

        // GET api/session/5
        public Session Get(int id)
        {
            return SessionRepository.Single(id);
        }

        // POST api/session
        public void Post([FromBody]Session value)
        {
            SessionRepository.Add(value);
        }

        // PUT api/session/5
        public void Put(int id, [FromBody]Session value)
        {
            SessionRepository.Update(value);
        }

        // DELETE api/session/5
        public void Delete(int id)
        {
            SessionRepository.Delete(id);
        }
    }
}
