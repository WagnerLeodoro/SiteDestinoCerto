#pragma checksum "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59fb618e62fe94130dcc1cd3b2d3e2c1ebcc8483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Lista), @"mvc.1.0.view", @"/Views/Usuario/Lista.cshtml")]
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
#line 1 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
using destinoCerto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59fb618e62fe94130dcc1cd3b2d3e2c1ebcc8483", @"/Views/Usuario/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48fca4f4b0c25a29908febe261b69b26ff4887b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
  
    ViewData["Title"] = "Listagem de Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""list"">
    <div class=""title"">
        <h2>Usuários Cadastrados</h2>
    </div>
    <div class=""table-container"">
        <table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Nome</th>
                    <th>Login</th>
                    <th>Senha</th>
                    <th>Data de Nascimento</th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
                 foreach (Usuario u in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 26 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
                       Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 27 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
                       Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 28 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
                       Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 29 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
                       Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 30 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
                       Write(u.DataNascimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 960, "\"", 991, 2);
            WriteAttributeValue("", 967, "/Usuario/Editar?id=", 967, 19, true);
#nullable restore
#line 32 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
WriteAttributeValue("", 986, u.Id, 986, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar |</a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1036, "\"", 1068, 2);
            WriteAttributeValue("", 1043, "/Usuario/Remover?id=", 1043, 20, true);
#nullable restore
#line 33 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
WriteAttributeValue("", 1063, u.Id, 1063, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remover</a>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 36 "/home/wagnerleodoro/Documentos/curso-ipi-senac/Disciplinas/estruturarBD/atv02/destinoCerto/Views/Usuario/Lista.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
