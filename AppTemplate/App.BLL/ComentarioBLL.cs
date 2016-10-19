using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;

namespace App.BLL
{
    public class ComentarioBLL
    {
        private ComentarioRepo _comentarioRepo;

        public ComentarioBLL()
        {
            _comentarioRepo = new ComentarioRepo();
        }
        public void Agregar(Comentario comentario)
        {
            _comentarioRepo.Agregar(comentario);
        }
        public void Borrar(Comentario comentario)
        {
            _comentarioRepo.Borrar(comentario);
        }

        public List<Comentario> TraerTodo()
        {
            return _comentarioRepo.TraerTodo();
        }

        public Comentario TraerId(int id)
        {
            return _comentarioRepo.TraerId(id);
        }

    }
}
