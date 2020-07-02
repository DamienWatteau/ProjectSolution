using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.models
{
    public class FileDecrypt
    {
        public string FilePath { get; set; }

        public string Key { get; set; }

        public int Fiability { get; set; }

        public string TxtFile { get; set; }

    }
}