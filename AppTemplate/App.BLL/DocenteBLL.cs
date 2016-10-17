using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;

namespace App.BLL
{
    public class DocenteBLL
    {
        private DocenteRepo _docenteRepo;

        public DocenteBLL()
        {
            _docenteRepo = new DocenteRepo();
        }
        public void Agregar(Docente docente)
        {
            _docenteRepo.Agregar(docente);
        }
        public void Borrar(Docente docente)
        {
            _docenteRepo.Borrar(docente);
        }

        public List<Docente> TraerTodo()
        {
            return _docenteRepo.TraerTodo();
        }

        public Docente TraerId(int id)
        {
            return _docenteRepo.TraerId(id);
        }
    }
}
