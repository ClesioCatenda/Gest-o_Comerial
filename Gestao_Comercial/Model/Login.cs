using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Login
    {
        public int ID { get; set; }
        public String login { get; set; }
        public String nome { get; set; }
        public String senha { get; set; }
        public String email { get; set; }
        public int idPerfil { get; set; }
    }
}
