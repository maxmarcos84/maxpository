using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CajaChica.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Legajo { get; set; }
        public string Iniciales { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
