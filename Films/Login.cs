using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    class Login
    {
        public class Films
        {
            private string _username;

            public string Userame
            {
                get { return _username; }
                set { _username = value; }
            }
            private string _password;
            public string Password
            {
                get { return _password; }
                set { _password = value; }
            }

            public Films(string username, string password)
            {
                _username = username;
                _password = password;
                
            }
        }

    }
}
