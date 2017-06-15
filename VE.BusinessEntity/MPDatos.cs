using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VE.BusinessEntity.Base;
using System.Collections;

namespace VE.BusinessEntity
{
    public class MPDatos
    {
        public Cliente Afiliacion { get; set; }
        public BEClienteCanalAfiliacion CanalAfiliacion { get; set; }
        public BEOperadores Operador { get; set; }
        public BEClienteEstadoCivil estadoCivil { get; set; }
        public IList<BEOperadores> ListaOperador { get; set; }

    }
    public struct Respuesta
    {
        public const string RespuestaOK = "Respuesta-OK";
        public const string ResouestaError = "Respuesta-Fail";

    }
}
