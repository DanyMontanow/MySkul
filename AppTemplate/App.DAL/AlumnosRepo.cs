using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class AlumnosRepo
    {
        private AppDBContext _contexto;

        public AlumnosRepo()
        {
            _contexto = new AppDBContext();
        }
        /// <summary>
        /// Agregar Alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Agregar(Alumno alumno)
        {
            _contexto.Alumno.Add(alumno);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// Borrar alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Borrar(Alumno alumno)
        {
            _contexto.Alumno.Remove(alumno);
            _contexto.SaveChanges();
        }

    }
}