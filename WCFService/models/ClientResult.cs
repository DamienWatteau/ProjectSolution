using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.models
{
    [DataContract]
    public class ClientResult
    {
        [DataMember]
        public Boolean Status { get; set; }
        [DataMember]
        public string TokenUser { get; set; }

    }
}