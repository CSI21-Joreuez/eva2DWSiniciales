using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DAL.ToDAO
{
    internal class DTOEvaCatToDAO
    {

        public static DAL.EvaCatEvaluacion evaCatToDAO(DAL.EvaCatEvaluacion evaCatNotasDTO)
        {
            //Creamos un Objeto dao de la Tabla Catalogo notas
            DAL.EvaCatEvaluacion DaoDeCatalogo = new DAL.EvaCatEvaluacion();
            //Asignamos Cada uno de los Campos del DTO al DAO Catalogo Notas
            DaoDeCatalogo.CodEvaluacion = evaCatNotasDTO.CodEvaluacion;
            DaoDeCatalogo.DescEvaluacion = evaCatNotasDTO.DescEvaluacion;

            //Devolvemos el DAO Catalogo Notas 
            return DaoDeCatalogo;

        }
    }
}
