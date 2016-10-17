using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL
{
    public class MateriaRepo
    {
        private AppDBContext _contexto;

        public MateriaRepo()
        {
            _contexto = new AppDBContext();
        }
        /// <summary>
        /// Agregar materia
        /// </summary>
        /// <param name="materia"></param>
        public void Agregar(Materia materia)
        {
            _contexto.Materia.Add(materia);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// Borrar materia
        /// </summary>
        /// <param name="materia"></param>
        public void Borrar(Materia materia)
        {
            _contexto.Materia.Remove(materia);
            _contexto.SaveChanges();
        }
        /// <summary>
        /// muestra registros deseados
        /// </summary>
        /// <returns></returns>
        public List<Materia> TraerTodo()
        {
            return _contexto.Materia.OrderBy(x => x.Id).ToList();
        }
        public Materia TraerId(int Id)
        {
            return _contexto.Materia.FirstOrDefault(x => x.Id == Id);
        }
    }
}
