﻿using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace App.Entities
{
    public class Publicacion


    {
        [Key]

        public int Id { get; set; }
        public int IdDocente { get; set; }
=======
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Publicacion
    { 
        [Key]
        public int IDDocente { get; set; }
>>>>>>> Publicacion
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
