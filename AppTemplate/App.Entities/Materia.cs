using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
