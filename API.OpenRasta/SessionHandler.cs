using API.Data;
using OpenRasta.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.OpenRasta
{
    public class SessionHandler
    {
        public List<Session> Get()
        {
            return SessionRepository.All().ToList();
        }

        public Session Get(int id)
        {
            return SessionRepository.Single(id);
        }

        public OperationResult Post(Session item)
        {
            SessionRepository.Add(item);
            return new OperationResult.Created();
        }

        public OperationResult Put(int id, Session item)
        {
            Session data = SessionRepository.Single(id);
            data.Name = item.Name;
            data.Room = item.Room;
            data.Speaker = item.Speaker;
            SessionRepository.Update(data);
            return new OperationResult.OK();
        }

        public void Delete(int id)
        {
            SessionRepository.Delete(id);
        }
    }
}