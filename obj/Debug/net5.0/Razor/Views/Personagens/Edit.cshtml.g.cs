#pragma checksum "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d0cf9b3875f5870c1295eb09b21143f705cf777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personagens_Edit), @"mvc.1.0.view", @"/Views/Personagens/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0cf9b3875f5870c1295eb09b21143f705cf777", @"/Views/Personagens/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea8742186739939b51d95376aeaeffef3697b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Personagens_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RpgMvc.Models.PersonagemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml"
  
 ViewBag.Title = "Editar Personagem"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Editar dados do Personagem</h2>\r\n");
#nullable restore
#line 6 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml"
 using (Html.BeginForm()) 
{ 
 

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"form-horizontal\">\r\n <hr />\r\n <div class=\"form-group\">\r\n");
#nullable restore
#line 12 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml"
Write(Html.LabelFor(model => model.Id, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n <div class=\"col-md-6\"> \r\n");
#nullable restore
#line 14 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml"
Write(Html.EditorFor(model => model.Id, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n </div>\r\n </div>\r\n<div class=\"form-group\">\r\n ");
#nullable restore
#line 18 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml"
Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n <div class=\"col-md-6\">\r\n ");
#nullable restore
#line 20 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml"
Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n </div>\r\n </div> \r\n<div class=\"form-group\">\r\n <div class=\"col-md-offset-2 col-md-6\">\r\n <input type=\"submit\" value=\"Salvar altera????es\" class=\"btn btn-primary\" />\r\n </div>\r\n </div>\r\n </div>\r\n");
#nullable restore
#line 29 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n ");
#nullable restore
#line 31 "C:\Users\Carlos\Desktop\DS-CARLOSKAUAN\RpgMvc\Views\Personagens\Edit.cshtml"
Write(Html.ActionLink("Retornar", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RpgMvc.Models.PersonagemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
