using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VE.BusinessEntity;
using VE.BusinessEntity.Base;

namespace VE.DataAccess.SQL
{
    public class DAafiliacion
    {
        //agruparmos clases
        //public  MPDatos Lista_Operador()
        //{
        //    var operador = new BEOperadores();
        //    operador.EsActivo = true;
        //    operador.IdTipoOperador = 1;
        //    operador.TipoOperador = "Entel";
        //    return new MPDatos { Operador = operador };

        //}

        public MPDatos Lista_Operador()
        {
            var operador = new BEOperadores();
            operador.EsActivo = true;
            operador.IdTipoOperador = 1;
            operador.TipoOperador = "Entel";
            var opera = new List<BEOperadores>();

            opera.Add(operador);
            return new MPDatos { ListaOperador = opera };

        }
    }
}
