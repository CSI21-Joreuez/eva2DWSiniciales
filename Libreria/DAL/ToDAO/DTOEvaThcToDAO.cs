using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DAL.ToDAO
{
    public class DTOEvaThcToDAO
    {

        public static DAL.EvaTchNotasEvaluacion evaThcToDAO(DAL.EvaTchNotasEvaluacion evaTchNotasDTO)
        {
            //Creamos un Objeto dao de la Tabla Notas
        DAL.EvaTchNotasEvaluacion DaoDeNotas = new DAL.EvaTchNotasEvaluacion();
            //Asignamos Cada uno de los Campos del DTO al DAO Notas
        DaoDeNotas.MdUuid=evaTchNotasDTO.MdUuid;
        DaoDeNotas.MdFch = evaTchNotasDTO.MdFch;
        DaoDeNotas.CodAlumno = evaTchNotasDTO.CodAlumno;
        DaoDeNotas.NotaEvaluacion = evaTchNotasDTO.NotaEvaluacion;
        DaoDeNotas.CodEvaluacion = evaTchNotasDTO.CodEvaluacion;
            //Devolvemos el DAO NOTAS 
        return DaoDeNotas;

        }

    }
}
