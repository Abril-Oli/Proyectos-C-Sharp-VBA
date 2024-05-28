using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaClase9
{
    public class Usuario
    {
        public long id { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        public Usuario(long id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public Usuario()
        {
        }
    }
}
