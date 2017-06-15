using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VE.BusinessEntity;
using VE.BusinessLogical;
using WU.Compras.Publicidad.PE.Wallet.Models.Abstract;


namespace WU.Compras.Publicidad.PE.Wallet.Models.Repository
{
    public class AfiliaRepositorio : IAfilicion
    {
        public MPDatos Lista_Operador()
        {
            return new BLAfilia().Lista_Operador();
        }
    }
}
