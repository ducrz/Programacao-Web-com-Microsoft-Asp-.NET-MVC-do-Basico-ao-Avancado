#pragma checksum "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c1a5c288273fa3915323721317706a770b0389a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__mensagensPartial), @"mvc.1.0.view", @"/Views/Shared/_mensagensPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\_ViewImports.cshtml"
using LojaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\_ViewImports.cshtml"
using LojaWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1a5c288273fa3915323721317706a770b0389a", @"/Views/Shared/_mensagensPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db12b399f94c146beb68debf1b076d184ed6543", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__mensagensPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"
 if (ViewData["Error"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissible\">\r\n        <a class=\"close\" data-dismiss=\"alert\" href=\"#\" aria-hidden=\"true\">&times;</a>\r\n        <strong>Erro: </strong>");
#nullable restore
#line 5 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"
                          Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"
 if (ViewData["Warning"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissible\">\r\n        <a class=\"close\" data-dismiss=\"alert\" href=\"#\" aria-hidden=\"true\">&times;</a>\r\n        <strong>Atenção: </strong>");
#nullable restore
#line 14 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"
                             Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"
 if (ViewData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible\">\r\n        <a class=\"close\" data-dismiss=\"alert\" href=\"#\" aria-hidden=\"true\">&times;</a>\r\n        <strong>Sucesso: </strong>");
#nullable restore
#line 23 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"
                             Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"
 if (ViewData["Informação"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info alert-dismissible\">\r\n        <a class=\"close\" data-dismiss=\"alert\" href=\"#\" aria-hidden=\"true\">&times;</a>\r\n        <strong>Informação: </strong>");
#nullable restore
#line 32 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"
                                Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 35 "C:\Users\eduardo\Source\Repos\ducrz\Programacao-Web-com-Microsoft-Asp-.NET-MVC-do-Basico-ao-Avancado\LojaVirtual\LojaWeb\Views\Shared\_mensagensPartial.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591