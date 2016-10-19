using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class ComentarioRepo
    {
        private AppDBContext _contexto;

        public ComentarioRepo()
        {
            _contexto = new AppDBContext();
        }
        /// <summary>
        /// Agregar Alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Agregar(Comentario comentario)
        {
            _contexto.Comentario.Add(comentario);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// Borrar alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Borrar(Comentario comentario)
        {
            _contexto.Comentario.Remove(comentario);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// muestra registros deseados
        /// </summary>
        /// <returns></returns>
        public List<Comentario> TraerTodo()
        {
            return _contexto.Comentario.OrderBy(x => x.Id).ToList();
        }
        public Comentario TraerId(int Id)
        {
            return _contexto.Comentario.FirstOrDefault(x => x.Id == Id);
        }
    }
}
