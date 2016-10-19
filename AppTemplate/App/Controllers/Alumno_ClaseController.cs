using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class Alumno_ClaseController : Controller
    { 
        private Alumnos_ClaseBLL _alumnos_claseBLL;
        private Alumnos_Clase _alumnos_claseEntity;

        public Alumno_ClaseController()
        {
            _alumnos_claseEntity = new Alumnos_Clase();
            _alumnos_claseBLL = new Alumnos_ClaseBLL();
        }
        // GET: Alumno
        public ActionResult Index()
        {
            _alumnos_claseEntity.IdAlumno = 0;
            _alumnos_claseEntity.IdClase = 0;
            _alumnos_claseEntity.IdDocente = 0;
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }
    }
}