using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.Data
{
    public class Session
    {
        public int SessionID { get; set; }
        public string Name { get; set; }
        public string Speaker { get; set; }
        public string Room { get; set; }
    }
}
