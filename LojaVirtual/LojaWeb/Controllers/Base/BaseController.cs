using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Controllers.Base
{
    public class BaseController : Controller
    {
        public void Mensagem(string mensagem)
        {

            ViewData["Mensagem"] = mensagem;

        }
    }
}
