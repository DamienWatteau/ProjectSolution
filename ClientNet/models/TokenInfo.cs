using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNet.models
{
    public class TokenInfo
    {
        private string tokenApp;
        private string tokenUser;
        private string tokenAppVersion;

        public TokenInfo() {
            this.tokenApp = "ABC";
            this.tokenAppVersion = "v1";
        }


        public string TokenApp { get => tokenApp; set => tokenApp = value; }
        public string TokenUser { get => tokenUser; set => tokenUser = value; }
        public string TokenAppVersion { get => tokenAppVersion; set => tokenAppVersion = value; }

    }
}
