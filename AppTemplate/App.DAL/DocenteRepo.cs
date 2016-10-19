using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class DocenteRepo
    {
        private AppDBContext _contexto;

        public DocenteRepo()
        {
            _contexto = new AppDBContext();
        }
        /// <summary>
        /// Agregar docente
        /// </summary>
        /// <param name="docente"></param>
        /// 
        public void Agregar(Docente docente)
        {
            _contexto.Docente.Add(docente);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// Borrar docente
        /// </summary>
        /// <param name="alumno"></param>
        public void Borrar(Docente docente)
        {
            _contexto.Docente.Remove(docente);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// muestra registros deseados
        /// </summary>
        /// <returns></returns>
        public List<Docente> TraerTodo()
        {
            return _contexto.Docente.OrderBy(x => x.Id).ToList();
        }
        public Docente TraerId(int Id)
        {
            return _contexto.Docente.FirstOrDefault(x => x.Id == Id);
        }
    }
}
