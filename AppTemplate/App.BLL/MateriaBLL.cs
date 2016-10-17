using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;

namespace App.BLL
{
     public class MateriaBLL
    {
        private MateriaRepo _materiaRepo;

        public MateriaBLL()
        {
            _materiaRepo = new MateriaRepo();
        }
        public void Agregar(Materia materia)
        {
            _materiaRepo.Agregar(materia);
        }
        public void Borrar(Materia materia)
        {
            _materiaRepo.Borrar(materia);
        }

        public List<Materia> TraerTodo()
        {
            return _materiaRepo.TraerTodo();
        }

        public Materia TraerId(int id)
        {
            return _materiaRepo.TraerId(id);
        }
    }
}
