using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DAL;
using App.Entities;

namespace App.BLL
{

  public class Alumnos_ClaseBLL
  {
    private Alumnos_ClaseRepo _alumno_claseRepo;

    public Alumnos_ClaseBLL()
    {
         _alumno_claseRepo = new Alumnos_ClaseRepo();
    }
    public void Agregar(Alumnos_Clase alumno_clase)
    {
        _alumno_claseRepo.Agregar(alumno_clase);
    } 
    public void Borrar(Alumnos_Clase alumno_clase)
    {
     _alumno_claseRepo.Borrar(alumno_clase);
    }
    public List<Alumnos_Clase> TraerTodo()
   {
     return _alumno_claseRepo.TraerTodo();
   }
   public Alumnos_Clase TraerId(int id)
   {
    return _alumno_claseRepo.TraerId(id);
   }
   }
}
