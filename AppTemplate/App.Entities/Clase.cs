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
        [Key]
        public int Id { get; set; }
        public int IdMateria { get; set; }
        public int IdDocente { get; set; }
    }
}
