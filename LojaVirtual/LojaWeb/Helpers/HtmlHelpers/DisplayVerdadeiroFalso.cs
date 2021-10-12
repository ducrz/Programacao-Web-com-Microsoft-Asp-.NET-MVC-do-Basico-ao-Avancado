using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Helpers.HtmlHelpers
{
    public static class DisplayVerdadeiroFalso
    {
   
            public static IHtmlContent DisplayTrueFalse(bool valueBooleano)
            {
                var span = new TagBuilder("span");
                if (valueBooleano)
                {
                    span.AddCssClass("badge badge-success");
                    span.InnerHtml.Append("Verdadeiro");
                }
                else
                {
                    span.AddCssClass("badge badge-danger");
                    span.InnerHtml.Append("Falso");
                }
                return span;
            }
        }
    }

