using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            return View(new BaseViewModel()
            {
                NomeView= "Cadastro"
            }
            );
        }
    }
}