using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Libreria.DAL.DTO
{
    public class DTOEvaThcNotas
    {
        public long IdNotaEvaluacion { get; set; }

        public string MdUuid { get; set; } = null!;

        public DateTime MdFch { get; set; }

        public string CodAlumno { get; set; } = null!;

        public long NotaEvaluacion { get; set; }

        public string CodEvaluacion { get; set; } = null!;

        public DTOEvaThcNotas( string codAlumno, long notaEvaluacion, string codEvaluacion)
        {
            Guid myUUId = Guid.NewGuid();
            MdUuid = myUUId.ToString();
            MdFch = DateTime.Now;
            CodAlumno = codAlumno;
            NotaEvaluacion = notaEvaluacion;
            CodEvaluacion = codEvaluacion;
        }

    }
}
