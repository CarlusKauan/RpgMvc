#pragma checksum "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef48059b290a9e6bd546eae476b63cdb9442a4aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Armas_Create), @"mvc.1.0.view", @"/Views/Armas/Create.cshtml")]
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
#line 1 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\_ViewImports.cshtml"
using RpgMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef48059b290a9e6bd546eae476b63cdb9442a4aa", @"/Views/Armas/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Armas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.ArmaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
  
    ViewBag.Title = "Nova Arma";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
 if (@TempData["Mensagem"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 10 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Configuração para exibir mensagem de erro -->\r\n");
#nullable restore
#line 12 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
 if (@TempData["MensagemErro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-center\">Criar um Nova Arma</h2>\r\n");
#nullable restore
#line 19 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
       Write(Html.LabelFor(model => model.Dano, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
           Write(Html.EditorFor(model => model.Dano, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        \r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
       Write(Html.LabelFor(model => model.PersonagemId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-6\">\r\n                ");
#nullable restore
#line 42 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
           Write(Html.EditorFor(model => model.PersonagemId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>  
        
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-6"">
                <input type=""submit"" value=""Salvar"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 52 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 54 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Armas\Create.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.ArmaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591