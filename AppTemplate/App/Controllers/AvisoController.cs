using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class AvisoController : Controller
    {
        private AvisoBLL _avisoBLL;
        private Aviso _avisoEntity;

        public AvisoController()
        {
            _avisoEntity = new Aviso();
            _avisoBLL = new AvisoBLL();
        } 

        // GET: Aviso
        public ActionResult Index()
        {
            _avisoEntity.Titulo = "";
            _avisoEntity.Descripcion = "";
            _avisoEntity.FechaHora = DateTime.Now;

            return View();
        }
    }
}