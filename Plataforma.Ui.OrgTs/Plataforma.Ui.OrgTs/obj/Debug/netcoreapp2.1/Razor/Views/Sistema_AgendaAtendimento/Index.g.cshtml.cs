#pragma checksum "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\Sistema_AgendaAtendimento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5039432f702ba6bb82927753a2863cecbb2c3e1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sistema_AgendaAtendimento_Index), @"mvc.1.0.view", @"/Views/Sistema_AgendaAtendimento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sistema_AgendaAtendimento/Index.cshtml", typeof(AspNetCore.Views_Sistema_AgendaAtendimento_Index))]
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
#line 1 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\_ViewImports.cshtml"
using Plataforma.Ui.OrgTs;

#line default
#line hidden
#line 2 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\_ViewImports.cshtml"
using Plataforma.Domain.Entities.NotMapped;

#line default
#line hidden
#line 3 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\_ViewImports.cshtml"
using Plataforma.Domain.Entities.Sistema;

#line default
#line hidden
#line 4 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\_ViewImports.cshtml"
using Plataforma.Ui.OrgTs.ViewModel;

#line default
#line hidden
#line 5 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\_ViewImports.cshtml"
using Plataforma.Ui.OrgTs.ViewComponents;

#line default
#line hidden
#line 6 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\_ViewImports.cshtml"
using Plataforma.Ui.OrgTs.ViewModel.Components;

#line default
#line hidden
#line 7 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\_ViewImports.cshtml"
using Plataforma.Repository.Interfaces;

#line default
#line hidden
#line 8 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\_ViewImports.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5039432f702ba6bb82927753a2863cecbb2c3e1e", @"/Views/Sistema_AgendaAtendimento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f31401908884db9e4a24e19d48fae8f000a7a976", @"/Views/_ViewImports.cshtml")]
    public class Views_Sistema_AgendaAtendimento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Retorno_Permissao_Grupo_Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/min/sistema/modal-agendamento.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/min/sistema/agendaAtendimento.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "menus/MenuAbasAtivos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "buscas/topoPesquisas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "menus/MenuUtilitarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\Sistema_AgendaAtendimento\Index.cshtml"
  
    ViewData["Title"] = "Agenda de Atendimento";

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(122, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(128, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5255c54d281412685337116135e5d33", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(189, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(195, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d15afb7dc3684dd4badd567bf235c875", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(256, 6, true);
                WriteLiteral("    \r\n");
                EndContext();
            }
            );
            BeginContext(265, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9779e4bd8cc43df9566940ccc596a34", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(304, 86, true);
            WriteLiteral("\r\n<section class=\"page-content\">\r\n    <section class=\"page-content-inner\">\r\n\r\n        ");
            EndContext();
            BeginContext(390, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e9087db306842b1b863928099a47680", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(429, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(441, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68a853a37b774ec29959bdbcd3468e7a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 16 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\Sistema_AgendaAtendimento\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new MenuUtilitariosViewModel() { listaPermissoesMenuUtilitarios = Model, menuUtilitario = new string[,] { { "incluir", "Sistema_AgendaAtendimento/interno" } } };

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(650, 354, true);
            WriteLiteral(@"

    </section>

    <section class=""page-content-inner"">     
        <div class=""row"">
            <div class=""col-lg-12"">
                <section class=""panel"">
                    <div class=""panel-heading"">
                        <div class=""row"">
                            <div class=""col-lg-3"">
                                <h1>");
            EndContext();
            BeginContext(1005, 17, false);
#line 27 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\Sistema_AgendaAtendimento\Index.cshtml"
                               Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 673, true);
            WriteLiteral(@"</h1>
                            </div>
                            <div class=""col-lg-9"">

                            </div>
                        </div>
                    </div>
                    <div class=""panel-body"">
                        <div class=""panel panel-with-sidebar"">
                            <div class=""panel-sidebar"">
                                <h2>Agenda do dia</h2>
                                <div class=""list-group lista-info-agenda-dia"">


                                </div>
                            </div>
                            <div class=""panel-body height-700"">
                                ");
            EndContext();
            BeginContext(1696, 23, false);
#line 44 "C:\Users\joaop\Desktop\plataformaBiblioteco\Plataforma.Ui.OrgTs\Plataforma.Ui.OrgTs\Views\Sistema_AgendaAtendimento\Index.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1719, 1267, true);
            WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-lg-12"">
                                        <div class=""calendario""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </div>        
    </section>
</section>

<div class=""modal fade"" id=""modal-agendamento-info-dia"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h3 class=""modal-title"">Agendamento</h3>
            </div>
            <div class=""modal-body info-agenda-dia font-size-14"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""b");
            WriteLiteral("tn btn-default\" data-dismiss=\"modal\">Fechar</button>\r\n                <button type=\"button\" class=\"btn btn-warning pull-left bt-altera-agendamento\" data-dismiss=\"modal\">Alterar</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Retorno_Permissao_Grupo_Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591