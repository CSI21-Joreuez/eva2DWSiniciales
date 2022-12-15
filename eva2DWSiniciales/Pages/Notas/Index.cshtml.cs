using Libreria.DAL.DTO;
using Libreria.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Libreria.DAL.ToDAO;
using System.Threading.Tasks.Dataflow;

namespace eva2DWSiniciales.Pages.Insert
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public DTOEvaThcNotas notasDTO { get; set; }

        [BindProperty]
        public string codAlumno { get; set; }
        [BindProperty]
        public int notaEvaluacion { get; set; }
        [BindProperty]
        public string codEvaluacion { get; set; }





        private BdEvaluacionContext db;


        public IndexModel(BdEvaluacionContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            //Añadimos las notas evaluacion a la bbdd

            db.SaveChanges();

            Console.WriteLine("El usuariose ha añadido correctamente");
            //Redirigimos al Usuario al Login
            return RedirectToPage("./Index");
        }
    }
}

