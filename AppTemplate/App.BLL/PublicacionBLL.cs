using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;

namespace App.BLL
{
    public class PublicacionBLL
    {
        private PublicacionRepo _publicacionRepo;

        public PublicacionBLL()
        {
            _publicacionRepo = new PublicacionRepo();
        }
        public void Agregar(Publicacion publicacion)
        {
            _publicacionRepo.Agregar(publicacion);
        }
        public void Borrar(Publicacion publicacion)
        {
            _publicacionRepo.Borrar(publicacion);
        }

        public List<Publicacion> TraerTodo()
        {
            return _publicacionRepo.TraerTodo();
        }

        public Publicacion TraerId(int id)
        {
            return _publicacionRepo.TraerId(id);
        }
    }
}
