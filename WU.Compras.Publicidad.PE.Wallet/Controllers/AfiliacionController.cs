using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WU.Compras.Publicidad.PE.Wallet.Models.Entity;
using WU.Compras.Publicidad.PE.Wallet.Models.Abstract;
using WU.Compras.Publicidad.PE.Wallet.Models.Repository;
using Microsoft.AspNetCore.Authorization;

namespace WU.Compras.Publicidad.PE.Wallet.Controllers
{

    
    public class AfiliacionController : Controller
    {
        private IAfilicion _iafilicion;
    //    public AfiliacionController():this(new AfiliaRepositorio())
    //{
    //    }
        public AfiliacionController(IAfilicion iafilicionRepo)
        {
            _iafilicion = iafilicionRepo;
         
        }
 

        public IActionResult Afilia1()
        {
            var Afiliacion1 = new AfiliarClienteViewModel { AceptaPolitica = false, RecibeBoletin = true, RecibeTarjeta = true };
            //var 
            //ViewBag.Operador=
            var operador1= _iafilicion.Lista_Operador();
            //var operador = new AfiliaRepositorio().Lista_Operador();
            ViewBag.operador = operador1.ListaOperador;
            return View(Afiliacion1);
        }
    }
}