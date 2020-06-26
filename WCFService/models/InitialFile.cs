using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.models
{
    [DataContract]
    public class InitialFile
    {
        
        [DataMember]
        public string TokenUser { get; set; }
        [DataMember]
        public string TokenApp { get; set; }

        [DataMember]
        public FileStream TxtFile { get; set; }

    }
}