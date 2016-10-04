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
        /// <summary>
        /// Llave primaria 
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Docente
        /// </summary>
        public int IdDocente { get; set; }
        /// <summary>
        /// Titulo
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Fecha y Hora
        /// </summary>
        public DateTime FechaHora { get; set; }
    }
}
