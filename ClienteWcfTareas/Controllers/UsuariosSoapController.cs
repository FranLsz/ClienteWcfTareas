using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClienteWcfTareas.TareasService;

namespace ClienteWcfTareas.Controllers
{
    public class UsuariosSoapController : Controller
    {
        // GET: UsuariosSoap
        public ActionResult Index()
        {
            var cl = new ServicioUsuarioClient();
            var users = cl.GetAllUsuario();

            return View(users);
        }

        public ActionResult Alta()
        {
            return View(new UsuarioDTO());
        }

        [HttpPost]
        public ActionResult Alta(UsuarioDTO model)
        {
            var cl = new ServicioUsuarioClient();
            cl.AddUsuario(model);
            return View(model);
        }
    }
}