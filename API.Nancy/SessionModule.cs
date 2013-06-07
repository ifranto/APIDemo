using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;
using API.Data;

namespace API.NancyFx
{
    public class SessionModule : NancyModule
    {
        public SessionModule()
        {
            Get["/sessions"] = parameters =>
            {
                return SessionRepository.All();
            };

            Get["/sessions/{id}"] = parameters =>
            {
                return SessionRepository.Single(parameters.id);
            };

            Post["/sessions"] = parameters =>
            {
                Session item = this.Bind();
                SessionRepository.Add(item);
                return HttpStatusCode.Created;
            };

            Put["/sessions/{id}"] = parameters =>
            {
                Session item = SessionRepository.Single(parameters.id);
                this.BindTo(item, s => s.SessionID);
                SessionRepository.Update(item);
                return HttpStatusCode.OK;
            };

            Delete["/sessions/{id}"] = parameters =>
            {
                SessionRepository.Delete(parameters.id);
                return HttpStatusCode.NoContent;
            };
        }
    }
}