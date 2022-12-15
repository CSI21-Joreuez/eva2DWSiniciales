using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Libreria.DAL;

namespace eva2DWSiniciales.Pages.Notas
{
    public class listaModel : PageModel
    {
        private readonly Libreria.DAL.BdEvaluacionContext _context;

        public listaModel(Libreria.DAL.BdEvaluacionContext context)
        {
            _context = context;
        }

        public IList<EvaTchNotasEvaluacion> EvaTchNotasEvaluacion { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.EvaTchNotasEvaluacions != null)
            {
                EvaTchNotasEvaluacion = await _context.EvaTchNotasEvaluacions
                .Include(e => e.CodEvaluacionNavigation).ToListAsync();
            }
        }
    }
}
