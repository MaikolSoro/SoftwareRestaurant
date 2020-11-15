using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaRestaurant.BOL
{
    public class Ltables
    {
        public int Id_table { get; set; }
        public string Table { get; set; }
        public int Id_salon { get; set; }
        public string life_state { get; set; }
        public string state_of_availability { get; set; }
    }
}
