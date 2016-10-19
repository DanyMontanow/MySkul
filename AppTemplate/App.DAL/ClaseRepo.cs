using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class ClaseRepo
    {
        private AppDBContext _contexto;

        public ClaseRepo()
        {
            _contexto = new AppDBContext();
        }
        /// <summary>
        /// Agregar docente
        /// </summary>
        /// <param name="clase"></param>
        public void Agregar(Clase clase)
        {
            _contexto.Clase.Add(clase);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// Borrar docente
        /// </summary>
        /// <param name="clase"></param>
        public void Borrar(Clase clase)
        {
            _contexto.Clase.Remove(clase);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// muestra registros deseados
        /// </summary>
        /// <returns></returns>
        public List<Clase> TraerTodo()
        {
            return _contexto.Clase.OrderBy(x => x.Id).ToList();
        }
        public Clase TraerId(int Id)
        {
            return _contexto.Clase.FirstOrDefault(x => x.Id == Id);
        }

    }
}
