﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Entities
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        public int IdAlumno { get; set; }
        public Alumno Alumno { get; set; }
        public int IdAviso { get; set; }
        public Aviso Aviso { get; set; }

    }
}
