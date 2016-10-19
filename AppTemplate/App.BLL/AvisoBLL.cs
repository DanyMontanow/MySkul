using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;

namespace App.BLL
{
    public class AvisoBLL
    {
        private AvisoRepo _avisoRepo;

        public AvisoBLL()
        {
            _avisoRepo = new AvisoRepo();
        }
        public void Agregar(Aviso Aviso)
        {
            _avisoRepo.Agregar(Aviso);
        }
        public void Borrar(Aviso Aviso)
        {
            _avisoRepo.Borrar(Aviso);
        }

        public List<Aviso> TraerTodo()
        {
            return _avisoRepo.TraerTodo();
        }

        public Aviso TraerId(int id)
        {
            return _avisoRepo.TraerId(id);
        }
    }
}
