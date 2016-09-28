using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace App.Entities
{
    public class Publicacion


    {
        [Key]

        public int Id { get; set; }
        public int IdDocente { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
