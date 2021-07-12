using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace Web.Controllers
{
    public class UsuarioController : Controller
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(listaUsuarios);
        }

        public ActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creat(Usuario model)
        {
            listaUsuarios.Add(model);
            return RedirectToAction("List");
        }
    }
}