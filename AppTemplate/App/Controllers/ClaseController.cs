using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class ClaseController : Controller
    {
        private ClaseBLL _claseBLL;
        private Clase _claseEntity;
        public ClaseController()
        {
            _claseEntity = new Clase();
            _claseBLL = new ClaseBLL();
        }
        // GET: Clase
        public ActionResult Index()
        {
            _claseEntity.IdMateria = 0;
            _claseEntity.Materia = "";

            return View();
        }
    }
}