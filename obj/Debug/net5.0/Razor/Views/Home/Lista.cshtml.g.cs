#pragma checksum "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/Home/Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9b018a6a44d63d2ca5adcc10374c81af2e88a7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lista), @"mvc.1.0.view", @"/Views/Home/Lista.cshtml")]
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
#line 1 "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/_ViewImports.cshtml"
using TakuCityPop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/_ViewImports.cshtml"
using TakuCityPop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9b018a6a44d63d2ca5adcc10374c81af2e88a7d", @"/Views/Home/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe60c0ea83f908146f16bb4502c6f3c187687cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/Home/Lista.cshtml"
  
    ViewData["Title"] = "Lista";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Lista</h2>\n<table>\n    <thead>\n        <tr>\n            <th>Id</th>\n            <th>Nome</th>\n            <th>Email</th>\n            <th>Data de Nascimento</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 17 "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/Home/Lista.cshtml"
         foreach (Usuario usuario in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 20 "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/Home/Lista.cshtml"
               Write(usuario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/Home/Lista.cshtml"
               Write(usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 22 "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/Home/Lista.cshtml"
               Write(usuario.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/Home/Lista.cshtml"
               Write(usuario.DataNascimento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 25 "/home/fantasioso/Documentos/00-tecinfo/Modulo 2/UC08B - Projeto/Atividade 05/TakuCityPop/Views/Home/Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
