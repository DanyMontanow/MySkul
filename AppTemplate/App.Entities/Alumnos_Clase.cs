using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Alumnos_Clase
    {
        /// <summary>
        /// Llave Primaria
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Alumno
        /// </summary>
        public int IdAlumno { get; set; }
        public Alumno Alumno { get; set; }
        /// <summary>
        /// Clase
        /// </summary>
        public int IdClase { get; set; }
        public Clase Clase { get; set; }
        /// <summary>
        /// Docente
        /// </summary>
        public int IdDocente { get; set; }
        public Docente Docente { get; set; }
        

    }
}
