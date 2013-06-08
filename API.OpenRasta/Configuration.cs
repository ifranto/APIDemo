using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpenRasta.Configuration;
using OpenRasta.Codecs;
using OpenRasta.Web;

namespace API.OpenRasta
{
    public class Configuration : IConfigurationSource
    {
        public void Configure()
        {
            using (OpenRastaConfiguration.Manual)
            {
                ResourceSpace.Has.ResourcesOfType<API.Data.Session>()
                    .AtUri("/sessions")
                    .And.AtUri("/sessions/{id}")
                    .HandledBy<SessionHandler>()
                    .TranscodedBy(typeof(JsonDataContractCodec)).ForMediaType(MediaType.Json).ForExtension("");
            }
        }
    }
}