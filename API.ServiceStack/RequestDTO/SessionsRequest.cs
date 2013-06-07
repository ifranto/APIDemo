using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ServiceStack.RequestDTO
{
    [Route("/sessions")]
    [Route("/sessions/{id}")]
    public class SessionsRequest
    {
        public int id { get; set; }
    }
}