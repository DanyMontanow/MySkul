using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class AlumnoController : Controller
    {
        private AlumnosBLL _alumnoBLL;
        private Alumno _alumnoEntity;
        public AlumnoController()
        {
            _alumnoEntity = new Alumno();
            _alumnoBLL = new AlumnosBLL();
        }
        // GET: Alumno
        public ActionResult Index()
        {
            _alumnoEntity.Nombre = "Moyses";
            _alumnoEntity.ApellidoPaterno = "Nevarez";
            _alumnoEntity.ApellidoMaterno = "Gonzalez";
            _alumnoEntity.NoControl = 1430206;
            _alumnoEntity.FechaDeNamiento = DateTime.Now;
            _alumnoEntity.Foto = "https://scontent-lax3-1.xx.fbcdn.net/v/t1.0-9/1234393_983440115023240_3344965876925717488_n.jpg?oh=13ae8966b084d1b031461a9f67994811&oe=589E4336";
            _alumnoEntity.Jefe = false;
            _alumnoBLL.Agregar(_alumnoEntity);
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }
    }
}