using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace App.Entities
{
    public class Aviso
    {
        public Aviso()
        {
            this.Comentarios = new HashSet<Comentario>();
            this.Enterados = new HashSet<Enterado>();
        }
        /// <summary>
        /// Llave primaria
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Titulo
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// FechaHora
        /// </summary>
        public DateTime FechaHora { get; set; }
        /// <summary>
        /// Relacion Comentario y Alumno
        /// </summary>
        public virtual ICollection<Comentario> Comentarios { get; set; }
        /// <summary>
        /// Realacion Aviso y Enterados
        /// </summary>
        public virtual ICollection<Enterado> Enterados { get; set; }
      
    }
}
