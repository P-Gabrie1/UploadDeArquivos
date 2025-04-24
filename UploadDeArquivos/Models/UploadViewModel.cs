using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace UploadDeArquivos.Models
{
    public class UploadViewModel
    {
        [Required]
        [Display(Name = "Selecione um arquivo")]
        public IFormFile Arquivo { get; set; }
    }
}
