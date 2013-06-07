using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Simple.Web;
using Simple.Web.Http;
using Simple.Web.Behaviors;
using API.Data;

namespace API.Simple.Web
{
    [UriTemplate("/sessions")]
    public class AllSessions : IGet, IOutput<List<Session>>
    {
        public Status Get()
        {
            Output = SessionRepository.All().ToList();
            return Status.OK;
        }


        public List<Session> Output {get;set;}
    }

    [UriTemplate("/sessions/{id}")]
    public class SingleSession : IGet, IOutput<Session>, IInput<SessionIDInput>
    {
        public Status Get()
        {
            Output = SessionRepository.Single(Input.id);
            return Status.OK;
        }

        public Session Output {get;set;}
        public SessionIDInput Input { get; set; }        
    }

    public class SessionIDInput
    {
        public int id { get; set; }
    }
}