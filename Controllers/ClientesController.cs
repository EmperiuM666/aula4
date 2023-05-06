using aula4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula4.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult DetailCliente(int ? id) 
        {
            using (BDTurmaBEntities9 bd = new BDTurmaBEntities9( ))
            {
                try
                {
                    clientes este = bd.clientes.Find(id??-1);
                    if(este != null) {
                        return View(este);  
                    }else {
                        return RedirectToAction("ListarClientes", "Clientes", new { msg= "Cliente não existe"});
                    }
                }
                catch (Exception erro)
                {
                    return RedirectToAction("ListarClientes", "Cliente", new { msg = erro.Message });
                    
                }
                
            }
        }
        public ActionResult ListarClientes(string msg)
        {
            using (BDTurmaBEntities9 bd = new BDTurmaBEntities9( ))
            {
                ViewBag.msg = msg;
                List<clientes> clientes = bd.clientes.ToList<clientes>();
                return View(clientes);
            }
        }
       
    }
}