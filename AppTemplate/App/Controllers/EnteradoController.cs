using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class EnteradoController : Controller
    {

        private EnteradoBLL _enteradoBLL;
        private Enterado _enteradoEntity;

        public EnteradoController()
        {
            _enteradoEntity = new Enterado();
            _enteradoBLL = new EnteradoBLL();
        }
        // GET: Enterado
        public ActionResult Index()
        {
            _enteradoEntity.IdAlumno = 0;
            _enteradoEntity.IdAviso = 0;
            return View();
        }
    }
}