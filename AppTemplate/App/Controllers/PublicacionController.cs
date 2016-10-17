using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class PublicacionController : Controller
    {
        private PublicacionBLL _publicacionBLL;
        private Publicacion _publicacionEntity;

        public PublicacionController()
        {
            _publicacionEntity = new Publicacion();
            _publicacionBLL = new PublicacionBLL();
        }

        // GET: Publicacion
        public ActionResult Index()
        {
            _publicacionEntity.IdDocente = 0;
            _publicacionEntity.Titulo = "";
            _publicacionEntity.Descripcion = "";
            _publicacionEntity.FechaHora = DateTime.Now;

            return View();
        }
    }
}