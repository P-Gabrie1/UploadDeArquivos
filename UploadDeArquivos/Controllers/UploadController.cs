using Microsoft.AspNetCore.Mvc;
using UploadDeArquivos.Models;
using System.IO;
using System.Threading.Tasks;

namespace UploadDeArquivos.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UploadViewModel model)
        {
            if (ModelState.IsValid && model.Arquivo != null)
            {
                var caminho = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", model.Arquivo.FileName);

                using (var stream = new FileStream(caminho, FileMode.Create))
                {
                    await model.Arquivo.CopyToAsync(stream);
                }

                ViewBag.Mensagem = "Arquivo enviado com sucesso!";
            }

            return View();
        }
    }
}
