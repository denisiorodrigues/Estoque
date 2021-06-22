using DR.App.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DR.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            if (id == 500)
            {
                modelErro.Message = "Ocorreu um erro! Tente novamente mais tarde ou contacte nosso suporte.";
                modelErro.Titulo = "Ocorreu um erro";
                modelErro.ErroCode = id;
            }
            else if (id == 404)
            {
                modelErro.Message = "A página que está procurando não existe! <br/> Em caso de dúvidas entre em contato com o nosso suporte.";
                modelErro.Titulo = "Página não encontrada.";
                modelErro.ErroCode = id;
            }
            else if(id == 403)
            {
                modelErro.Message = "Você não tem permissão para fazer isso.";
                modelErro.Titulo = "Acesso negado";
                modelErro.ErroCode = id;
            }
            else
            {
                return StatusCode(404);
            }


            return View("Error", modelErro); 
        }
    }
}
