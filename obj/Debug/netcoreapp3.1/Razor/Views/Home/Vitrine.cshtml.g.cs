#pragma checksum "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1afb4a00f264aa074da138fcb8ecc3b911e9692"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Vitrine), @"mvc.1.0.view", @"/Views/Home/Vitrine.cshtml")]
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
#line 1 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/_ViewImports.cshtml"
using destinoCerto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
using destinoCerto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1afb4a00f264aa074da138fcb8ecc3b911e9692", @"/Views/Home/Vitrine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48fca4f4b0c25a29908febe261b69b26ff4887b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vitrine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PacotesTuristicos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
  
    ViewData["Title"] = "Lista de Pacotes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""list"">
    <div class=""title"">
        <h2>Pacotes Disponíveis</h2>
    </div>
    <div class=""table-container"">
        <table>
            <thead>
                <tr>
                    <th>Nome</th>
                    <th>Origem</th>
                    <th>Destino</th>
                    <th>Atrativos</th>
                    <th>Saída</th>
                    <th>Retorno</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
                 foreach (PacotesTuristicos p in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 26 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
                       Write(p.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 27 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
                       Write(p.Origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 28 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
                       Write(p.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 29 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
                       Write(p.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 30 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
                       Write(p.Saida.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 31 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
                       Write(p.Retorno.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 33 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Home/Vitrine.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PacotesTuristicos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
