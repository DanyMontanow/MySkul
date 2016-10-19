using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;

namespace App.BLL
{
  public  class ClaseBLL
    {
        private ClaseRepo _claseRepo;

        public ClaseBLL()
        {
            _claseRepo = new ClaseRepo();
        }
        public void Agregar(Clase clase)
        {
            _claseRepo.Agregar(clase);
        }
        public void Borrar(Clase clase)
        {
            _claseRepo.Borrar(clase);
        }

        public List<Clase> TraerTodo()
        {
            return _claseRepo.TraerTodo();
        }

        public Clase TraerId(int id)
        {
            return _claseRepo.TraerId(id);
        }
    }
}
