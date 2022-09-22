using AppLoginAutenticacao.Models;
using AppLoginAutenticacao.ViewModels;
using AppAutenticacao.Outros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AppLoginAutenticacao.Controllers
{
    public class AutenticacaoController : Controller
    {
        // GET: Autenticacao
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(CadastroUsuarioViewModel viewmodel)
        {
            if(!ModelState.IsValid)
                return View(viewmodel);

            Usuario tempUsuario = new Usuario
            {
                UsuNome = viewmodel.UsuNome,
                Login = viewmodel.Login,
                Senha = Hash.GerarHash(viewmodel.Senha),
            };
            tempUsuario.InsertUsuario(tempUsuario);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult SelectLogin(string Login)
        {
            bool LoginExists;
            string login = new Usuario().SelectLogin(Login);    
            if(login.Length == 0)
            {
                LoginExists = false;
            }
            else
            {
                LoginExists = true;
            }
            return Json(!LoginExists, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Login(string ReturnUrl)
        {
            var viewmodel = new LoginViewModel
            {
                UrlRetorno = ReturnUrl
            };
            return View(viewmodel); 
        }
    }
}