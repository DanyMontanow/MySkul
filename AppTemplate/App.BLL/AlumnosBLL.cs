using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;
namespace App.BLL
{
    public class AlumnosBLL
    {
        private AlumnosRepo _alumnoRepo;

        public AlumnosBLL()
        {
            _alumnoRepo = new AlumnosRepo();
        }
        public void Agregar(Alumno alumno)
        {
            _alumnoRepo.Agregar(alumno);
        }
        public void Borrar(Alumno alumno)
        {
            _alumnoRepo.Borrar(alumno);
        }

        public List<Alumno> TraerTodo()
        {
            return _alumnoRepo.TraerTodo();
        }

        public Alumno TraerId(int id)
        {
            return _alumnoRepo.TraerId(id);
        }
    }
}
