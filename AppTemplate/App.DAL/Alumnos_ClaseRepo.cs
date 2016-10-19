using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
   public class Alumnos_ClaseRepo
    {
        private AppDBContext _contexto;

        public Alumnos_ClaseRepo()
        {
            _contexto = new AppDBContext();
        }
        /// <summary>
        /// Agregar Alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Agregar(Alumnos_Clase alumno_clase)
        {
            _contexto.Alumno_Clase.Add(alumno_clase);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// Borrar alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Borrar(Alumnos_Clase alumno_clase)
        {
            _contexto.Alumno_Clase.Remove(alumno_clase);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// muestra registros deseados
        /// </summary>
        /// <returns></returns>
        public List<Alumnos_Clase> TraerTodo()
        {
            return _contexto.Alumno_Clase.OrderBy(x => x.Id).ToList();
        }
        public Alumnos_Clase TraerId(int Id)
        {
            return _contexto.Alumno_Clase.FirstOrDefault(x => x.Id == Id);
        }
    }
}
