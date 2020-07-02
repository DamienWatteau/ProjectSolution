using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientNet.models
{
    public class ClientProperties
    {
        private string username;
        private string password;
        private static TokenInfo tokenInfo;
        static ClientProperties clientProperties;

        ClientProperties() {
            tokenInfo = new TokenInfo();
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public TokenInfo TokenInfo { get => tokenInfo; set => tokenInfo = value; }

        public static ClientProperties getInstance()
        {
            if (clientProperties == null)
            {
                clientProperties = new ClientProperties();
            }
            return clientProperties;
        }


    }
}
