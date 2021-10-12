using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaWeb.Helpers.TagHelpers
{
    [HtmlTargetElement("nome-pessoa")]
    public class RazorTagHelper : TagHelper
    {
        public string nome { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var span = new TagBuilder("span");
            span.AddCssClass("badge badge-info");
            span.InnerHtml.Append(nome);
            output.Content.AppendHtml(span);
        }
    }
}
