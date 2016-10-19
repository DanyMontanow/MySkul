using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class AvisoRepo
    {
        private AppDBContext _contexto;

        public AvisoRepo()
        {
            _contexto = new AppDBContext();
        }
        /// <summary>
        /// Agregar Alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Agregar(Aviso aviso)
        {
            _contexto.Aviso.Add(aviso);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// Borrar alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void Borrar(Aviso aviso)
        {
            _contexto.Aviso.Remove(aviso);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// muestra registros deseados
        /// </summary>
        /// <returns></returns>
        public List<Aviso> TraerTodo()
        {
            return _contexto.Aviso.OrderBy(x => x.Id).ToList();
        }
        public Aviso TraerId(int Id)
        {
            return _contexto.Aviso.FirstOrDefault(x => x.Id == Id);
        }
    }
}
