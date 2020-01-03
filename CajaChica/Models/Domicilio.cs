using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CajaChica.Models
{
    public class Domicilio
    {
        [ForeignKey ("Persona")]
        public int Id { get; set; }

        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }

        public virtual Persona Persona { get; set; }

    }
}
