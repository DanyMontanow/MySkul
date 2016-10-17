using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class PublicacionRepo
    {
        private AppDBContext _contexto;

        public PublicacionRepo()
        {
            _contexto = new AppDBContext();
        }
        /// <summary>
        /// Agregar Publicacion
        /// </summary>
        /// <param name="publicacion"></param>
        public void Agregar(Publicacion publicacion)
        {
            _contexto.Publicacion.Add(publicacion);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// Borrar Publicacion
        /// </summary>
        /// <param name="publicacion"></param>
        public void Borrar(Publicacion publicacion)
        {
            _contexto.Publicacion.Remove(publicacion);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// muestra registros deseados
        /// </summary>
        /// <returns></returns>
        public List<Publicacion> TraerTodo()
        {
            return _contexto.Publicacion.OrderBy(x => x.Id).ToList();
        }
        public Publicacion TraerId(int Id)
        {
            return _contexto.Publicacion.FirstOrDefault(x => x.Id == Id);
        }
    }
}
