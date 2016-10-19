using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;

namespace App.BLL
{
    public class EnteradoBLL
    {
        private EnteradoRepo _enteradoRepo;

        public EnteradoBLL()
        {
            _enteradoRepo = new EnteradoRepo();
        }
        public void Agregar(Enterado enterado)
        {
            _enteradoRepo.Agregar(enterado);
        }
        public void Borrar(Enterado enterado)
        {
            _enteradoRepo.Borrar(enterado);
        }

        public List<Enterado> TraerTodo()
        {
            return _enteradoRepo.TraerTodo();
        }

        public Enterado TraerId(int id)
        {
            return _enteradoRepo.TraerId(id);
        }

    }
}
