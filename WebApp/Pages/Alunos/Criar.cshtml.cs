using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;  // Esta linha deve estar presente para que o namespace "Models" seja reconhecido

namespace WebApp.Pages.Alunos
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Aluno Aluno { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ViewData["Mensagem"] = $"Aluno criado: {Aluno.Nome} {Aluno.Sobrenome}";
            return Page();
        }
    }
}
