using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Controllers.Base
{
    public class BaseController : Controller
    {
        public void Mensagem(string mensagem, string tipoMensagem)
        {
            if (tipoMensagem == "Error"){
                ViewData["Error"] = "Erro";
            }
            else if (tipoMensagem == "Warning"){
                ViewData["Warning"] = "Warning";
            }
            else if (tipoMensagem == "Sucess"){
                ViewData["Sucess"] = "Success";
            }
            else{
                ViewData["Informação"] = "Informação";
            }
            ViewData["Mensagem"] = mensagem;

        }
    }
}
