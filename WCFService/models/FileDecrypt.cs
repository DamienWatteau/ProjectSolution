using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.models
{
    [DataContract]
    public class FileDecrypt
    {
        [DataMember]
        public string FilePath { get; set; }
        [DataMember]
        public string Key { get; set; }
        [DataMember]
        public string FileContentDecrypted { get; set; }
    }
}