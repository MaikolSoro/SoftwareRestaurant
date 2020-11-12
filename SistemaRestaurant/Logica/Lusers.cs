using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaRestaurant.Logica
{
    class Lusers
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Icon { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string State { get; set; }
    }
}
