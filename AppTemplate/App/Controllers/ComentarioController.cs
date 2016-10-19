using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Entities;

namespace App.Controllers
{
    public class ComentarioController : Controller
    {
        private ComentarioBLL _comentarioBLL;
        private Comentario _comentarioEntity;

        public ComentarioController()
        {
            _comentarioEntity = new Comentario();
            _comentarioBLL = new ComentarioBLL();
        }

        // GET: Comentario
        public ActionResult Index()
        {
            _comentarioEntity.IdAlumno = 0;
            _comentarioEntity.IdAviso = 0;
            return View();
        }
    }
}