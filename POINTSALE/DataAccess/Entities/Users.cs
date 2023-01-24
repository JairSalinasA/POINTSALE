using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Users
    {
        public int idusuario { get; set; }
        public string nombre { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string icono { get; set; }
        public string nombreicono { get; set; }
        public string correo { get; set; }
        public string rol { get; set; }
        public string apellido { get; set; }
    }
}
