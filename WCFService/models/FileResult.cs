using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.models
{
    [DataContract]
    public class FileResult
    {

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string File { get; set; }

        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public string PdfFile { get; set; }

    }
}