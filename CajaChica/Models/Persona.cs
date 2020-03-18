using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CajaChica.Models
{
    public class Persona
    {
        [ForeignKey("Empleado")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public virtual Domicilio Domicilio { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
