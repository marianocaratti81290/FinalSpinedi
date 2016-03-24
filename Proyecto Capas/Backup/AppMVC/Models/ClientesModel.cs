using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMVC.Models
{
    public class ClientesModel
    {
        
        
            [DisplayName("Nro.Clientes")]
            public int NroCliente { get; set; }

            [DisplayName("Razón Social")]
            public string RazonSocial { get; set; }

            [DisplayName("CUIL")]
            [Required(ErrorMessage = "El CUIL es requerido")]
            [StringLength(11, ErrorMessage = "Debe ingresar una cadena de 11 dígitos")]
            public string CUIL { get; set; }

            
        
    }
}