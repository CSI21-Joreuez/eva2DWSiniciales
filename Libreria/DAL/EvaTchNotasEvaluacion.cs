using System;
using System.Collections.Generic;

namespace Libreria.DAL;

public partial class EvaTchNotasEvaluacion
{
    public long IdNotaEvaluacion { get; set; }

    public string MdUuid { get; set; } = null!;

    public DateTime MdFch { get; set; }

    public string CodAlumno { get; set; } = null!;

    public long NotaEvaluacion { get; set; }

    public string CodEvaluacion { get; set; } = null!;

    public virtual EvaCatEvaluacion CodEvaluacionNavigation { get; set; } = null!;
}
