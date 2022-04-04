using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCORE.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }
        [Required(ErrorMessage ="El campo Nombre está vacio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El campo Teléfono está vacio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage ="El campo correo está vacio")]
        public string Correo { get; set; }
    }
}
