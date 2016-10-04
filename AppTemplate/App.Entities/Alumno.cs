using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace App.Entities
{
    public class Alumno
    {
           public Alumno()
        {
            this.Enterados = new HashSet<Enterado>();
            this.Comentarios = new HashSet<Comentario>();
            this.Alumnos_Clases = new HashSet<Alumnos_Clase>();
        }
        /// <summary>
        /// Llave primaria
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Nombre
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Apellido Paterno
        /// </summary>
        public string ApellidoPaterno { get; set; }
        /// <summary>
        /// Apellido Materno
        /// </summary>
        public string ApellidoMaterno { get; set; }
        /// <summary>
        /// NoControl
        /// </summary>
        public int NoControl { get; set; }
        /// <summary>
        /// Fecha De Nacimiento 
        /// </summary>
        public DateTime FechaDeNamiento { get; set; }
        /// <summary>
        /// Foto
        /// </summary>
        public string Foto { get; set; }
        /// <summary>
        /// Jefe
        /// </summary>
        public bool Jefe { get; set; }
        /// <summary>
        /// Relacion Alumnos y Enterado
        /// </summary>
        public virtual ICollection<Enterado> Enterados { get; set; }
        /// <summary>
        /// Relacion Alumno y Comenario
        /// </summary>
        public virtual ICollection<Comentario> Comentarios { get; set; }
        /// <summary>
        /// Relacion Alumno y Alumnos_Clase 
        /// </summary>
        public virtual ICollection<Alumnos_Clase> Alumnos_Clases { get; set; }

    }
}

