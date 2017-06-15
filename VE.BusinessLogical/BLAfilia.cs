using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VE.BusinessEntity;
using VE.DataAccess.SQL;

namespace VE.BusinessLogical
{
   public class BLAfilia
    {
        public MPDatos Lista_Operador()
        {
            return new DAafiliacion().Lista_Operador();
                     //return new AfiliacionDA().AgregarCliente(codigoAfiliacion);
        }
    }
}
