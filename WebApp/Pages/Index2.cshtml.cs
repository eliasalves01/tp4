using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class Index2Model : PageModel
    {
        // Remover o modificador 'public' da propriedade
        public string Mensagem { get; set; }

        public void OnGet()
        {
            Mensagem = "Olá pessoal";
        }
    }
}
