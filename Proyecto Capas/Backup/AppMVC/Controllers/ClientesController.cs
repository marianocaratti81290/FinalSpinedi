using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wflSistema;
using System.Data;

namespace AppMVC.Controllers
{
    public class ClientesController : Controller
    {

        
        //
        // GET: /Clientes/

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(ClientesModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.CUIL = model.CUIL;
            }
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Insertar(ClientesModel cli)
        {
            wflClientes owflcli = new wflClientes();
            string strmensaje="";
            owflcli.insertarRegistro(ref strmensaje, cli.NroCliente, cli.CUIL, cli.RazonSocial);
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Buscar(ClientesModel cli)
        {
            wflClientes owflcli = new wflClientes();
            DataTable cliente = new DataTable();
            ClientesModel _cliente = new ClientesModel();
            string strmensaje = "";
            owflcli.obtenerRegistro(cli.NroCliente,ref cliente );
            
            _cliente.NroCliente=Convert.ToInt16(cliente.Rows[0]["idcliente"]);
            _cliente.RazonSocial = cliente.Rows[0]["razonsocial"].ToString();
            _cliente.CUIL = cliente.Rows[0]["cuil"].ToString();


            return View(_cliente);
        }
    }
}
