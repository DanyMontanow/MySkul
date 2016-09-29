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
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int NoControl { get; set; }
        public DateTime FechaDeNamiento { get; set; }
        public string[] Foto { get; set; }
        public bool Jefe { get; set; }
    }
}

