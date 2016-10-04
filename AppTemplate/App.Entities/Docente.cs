using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    
   
    public class Docente
    {  
        public Docente()
        {          
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
        /// Foto
        /// </summary>
        public String Foto { get; set; }

        /// <summary>
        /// Relacion Docente y Alumnos_Clase
        /// </summary>

        public virtual ICollection<Alumnos_Clase> Alumnos_Clases { get; set; }
    
    }
}
