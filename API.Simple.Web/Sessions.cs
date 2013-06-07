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


        public List<Session> Output { get; set; }
    }

    [UriTemplate("/sessions/{id}")]
    public class SingleSession : IGet, IOutput<Session>
    {
        public Status Get()
        {
            Output = SessionRepository.Single(id);
            return Status.OK;
        }

        public Session Output { get; set; }
        public int id { get; set; }
    }

    [UriTemplate("/sessions")]
    public class PostSession : IPost, IInput<Session>
    {
        public Status Post()
        {
            SessionRepository.Add(Input);
            return Status.Created;
        }

        public Session Input { get; set; }
    }

    [UriTemplate("/sessions/{id}")]
    public class PutSession : IPut, IInput<Session>
    {
        public Status Put()
        {
            Session item = SessionRepository.Single(id);
            item.Name = Input.Name;
            item.Room = Input.Room;
            item.Speaker = Input.Speaker;
            SessionRepository.Update(item);
            return Status.OK;
        }

        public int id { get; set; }
        public Session Input { get; set; }
    }

    [UriTemplate("/sessions/{id}")]
    public class DeleteSession : IDelete
    {
        public Status Delete()
        {
            SessionRepository.Delete(id);
            return Status.NoContent;
        }

        public int id { get; set; }
    }
}