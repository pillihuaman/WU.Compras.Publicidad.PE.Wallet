using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WU.Compras.Publicidad.PE.Wallet.Models.Entity
{
    public class AfiliarClienteViewModel
    {

        //Metodos Virtuales Pedido,Stand,

        [Key]
        public Int64 IdCliente { get; set; }
        [Required(ErrorMessage = "Debe Ingresar su nombre")]
        [MaxLength(20, ErrorMessage = "no debe exceder de los 20 letras")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Debe Ingresar su Apellido Paterno")]
        [MaxLength(20, ErrorMessage = "no debe exceder de  20 letras")]
        public string ApellidoPaterno { get; set; }
        [Required(ErrorMessage = "Debe Ingresar su Apellido Materno")]
        [MaxLength(20, ErrorMessage = "no debe exceder de  20 letras")]
        public string ApellidoMaterno { get; set; }
        public int IdTipoDocumento { get; set; }
        [Required(ErrorMessage = "Debe ingresar su DNI")]
        [MaxLength(8, ErrorMessage = "no debe exceder de  8 digitos")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe ingresar solo numeros")]
        public string NumeroDocumento { get; set; }
        public string FechaEmisionDocumento { get; set; }
        [Required(ErrorMessage = "Debe ingresar su Email valido")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public int IdTipoOperador { get; set; }
        [Required(ErrorMessage = "Debe ingresar su Celular")]
        [MaxLength(9, ErrorMessage = "no debe exceder de  9 digitos")]
        public string NumeroMovil { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int IdEstadoCivil { get; set; }
        public byte? Genero { get; set; }
        public bool RecibeBoletin { get; set; }
        public bool AceptaPolitica { get; set; }
        //public int IdCanalAfiliacion { get; set; }
        public bool RecibeTarjeta { get; set; }
        public Guid CodigoAfiliacion { get; set; }
        public int IdEstadoCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdPerfil { get; set; }
        public int? IdReferido { get; set; }
        //public int? IdStand { get; set; }
        public string Usuario { get; set; }
        public int? IdTipoActivacion { get; set; }
    }
}