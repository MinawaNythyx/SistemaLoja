using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja
{
    class User
    {
        public string Usuario { get; set; }
        public string Password { get; set; }

        public bool ValidateUser(string user, string pass)
        {
            if(user == "Victor")
            {
                if(pass == "senha")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
