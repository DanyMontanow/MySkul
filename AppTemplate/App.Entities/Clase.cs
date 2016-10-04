using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Clase
    {
        /// <summary>
        /// Llave primaria
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Materia
        /// </summary>
        public int IdMateria { get; set; }
        public Materia Materia { get; set; }       
    }
}
