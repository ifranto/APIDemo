using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.ServiceStack.RequestDTO
{
    [Route("/sessions", "POST")]
    [Route("/sessions/{SessionID}", "PUT")]
    public class SessionRequest
    {
        public int SessionID { get; set; }
        public string Name { get; set; }
        public string Speaker { get; set; }
        public string Room { get; set; }
    }
}