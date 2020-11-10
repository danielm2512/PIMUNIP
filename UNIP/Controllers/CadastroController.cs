using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNIP.Models;

namespace UNIP.Controllers
{
    public class CadastroController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(DT_Pessoa _usuario)
        {
            if (ModelState.IsValid)
            {
                using (DB_UNIPPIMEntities4 dc = new DB_UNIPPIMEntities4())
                { 
                    dc.DT_Pessoa.Add(_usuario);
                    dc.SaveChanges();
                    ModelState.Clear();
                    _usuario = null;
                    ViewBag.Message = "Usuário registrado com sucesso.";
                }
            }
            return View(_usuario);
        }
    }
}