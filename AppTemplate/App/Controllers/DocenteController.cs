using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class DocenteController : Controller
    {
        private DocenteBLL _docenteBLL;
        private Docente _docenteEntity;
        public DocenteController()
        {
            _docenteEntity = new Docente();
            _docenteBLL = new DocenteBLL();
        }
        // GET: Docente
        public ActionResult Index()
        {
            _docenteEntity.Nombre = "";
            _docenteEntity.ApellidoPaterno = "";
            _docenteEntity.ApellidoMaterno = "";
            _docenteEntity.Foto = "";
            return View();
        }
    }
}