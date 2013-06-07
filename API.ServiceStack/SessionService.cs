using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceInterface;
using API.Data;

namespace API.ServiceStack
{
    public class SessionService : Service
    {
        public object Get(RequestDTO.SessionsRequest request)
        {
            if (request.id == 0)
            {
                return SessionRepository.All();
            }
            else
            {
                return SessionRepository.Single(request.id);
            }
        }

        public object Post(RequestDTO.SessionRequest request)
        {
            return SessionRepository.Add(new Session() { Name = request.Name, Speaker = request.Speaker, Room = request.Room });
        }

        public object Put(RequestDTO.SessionRequest request)
        {
            Session item = SessionRepository.Single(request.SessionID);
            item.Name = request.Name;
            item.Room = request.Room;
            item.Speaker = request.Speaker;
            return SessionRepository.Update(item);
        }

        public void Delete(RequestDTO.SessionsRequest request)
        {
            SessionRepository.Delete(request.id);
        }
    }
}