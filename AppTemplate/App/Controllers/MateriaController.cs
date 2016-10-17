using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class MateriaController : Controller
    {
        private MateriaBLL _materiaBLL;
        private Materia _materiaEntity;
        public MateriaController()
        {
            _materiaEntity = new Materia();
            _materiaBLL = new MateriaBLL();
        }

        // GET: Materia
        public ActionResult Index()
        {
            _materiaEntity.Nombre = "";
            return View();
        }
    }
}