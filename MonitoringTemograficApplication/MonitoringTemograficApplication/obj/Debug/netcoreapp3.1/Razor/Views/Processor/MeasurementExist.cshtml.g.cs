#pragma checksum "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b936af4845d6b6068a9c062ab5d1ed6e168aa9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Processor_MeasurementExist), @"mvc.1.0.view", @"/Views/Processor/MeasurementExist.cshtml")]
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
#line 1 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b936af4845d6b6068a9c062ab5d1ed6e168aa9a", @"/Views/Processor/MeasurementExist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2997e580c9b6263be232350ff96c15338f4a78e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Processor_MeasurementExist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MonitoringTemograficApplication.Models.Measurements>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
  
    ViewData["Title"] = "MeasuremntExist";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 style=\"text-align:center; \">Alterações Processadas</h1>\r\n\r\n<br />\r\n<br />\r\n<!--\r\n    Formulário\r\n    -- QueryString: Colaborador/Cliente/Index?pesquisa={palavraDigitada}&pagina=3\r\n-->\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 28 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\" justify-content:flex-end;  display:flex;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b936af4845d6b6068a9c062ab5d1ed6e168aa9a6435", async() => {
                WriteLiteral("Nova Alteração");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 36 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsivez"" id=""DivTb"">
        <table class=""table  table-bordered"" id=""Cptabela"">
            <thead>
                <tr>
                    <th scope=""col"">ID das Imagens</th>
                    <th scope=""col"">Data</th>
                    <th scope=""col"">Numero da Pnela</th>
                    <th scope=""col"">Vida Panela</th>
                    <th scope=""col"">Número da Corrida</th>
                    <th> </th>


                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 53 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                 foreach (Measurements measurements in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 56 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.MeasurementKey.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.Time.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 58 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.LadleID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 59 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.LadleAge.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 60 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.RaceNumber.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button type=\"button\" class=\"btn btn-outline-success\" onclick=\"mostrarModal()\">Atualizar</button></td>\r\n                       \r\n\r\n\r\n\r\n                       \r\n               \r\n                    </tr>\r\n");
#nullable restore
#line 69 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div id=\"DivBtn\">\r\n            ");
#nullable restore
#line 73 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page = page, search = pesquisa }), new PagedListRenderOptions
        {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "btn btn-outline-success text-right"}
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 81 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"



}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th scope=""col"">ID das Imagens</th>
                    <th scope=""col"">Data</th>
                    <th scope=""col"">Numero da Panela</th>
                    <th scope=""col"">Vida Panela</th>
                    <th scope=""col"">Número da Corrida</th>
                </tr>
            </thead>
        </table>
        <div>
            Nenhum registro cadastrado!
        </div>
    </div>
");
#nullable restore
#line 103 "C:\panelaupdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""modal"" class=""modal fade"" role=""dialog"">

    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h6 class=""modal-title""></h6>
            </div>

            <div class=""modal-body"">
                <input type=""hidden"" class=""form-control form-control-sm MeasurementKey"" />
                <div class=""form-group"">
                    <label>Id Das Imagens </label>
                    <input type=""text"" class=""form-control form-control-sm IddasImagens"" />
                    <span class=""text-danger erroNome d-IddasImagens""></span>
                </div>

                <div class=""form-group"">
                    <label>Data</label>
                    <input type=""number"" class=""form-control form-control-sm Data"" />
                    <span class=""text-danger erroIdade d-Data""></span>
                </div>

                <div class=""form-group"">
                    <label>Numero Panela</label>
          ");
            WriteLiteral(@"          <input type=""text"" class=""form-control form-control-sm .Numero Panela"" />
                    <span class=""text-danger erroProfissao d-NumeroPanela""></span>
                </div>

                <div class=""form-group"">
                    <label>Vida Panela</label>
                    <input type=""text"" class=""form-control form-control-sm .VidaPanela"" />
                    <span class=""text-danger erroProfissao d-VidaPanela""></span>
                </div>

                <div class=""form-group"">
                    <label>NumeroCorrida</label>
                    <input type=""text"" class=""form-control form-control-sm .NumeroCorrida"" />
                    <span class=""text-danger erroProfissao d-numerocorrida""></span>
                </div>
            </div>

            <div class=""modal-footer"">
                <div class=""form-group"">
                    <input type=""button"" value=""Salvar"" class=""btn btn-sm btn-outline-success btnSalvar"" />
                    <input typ");
            WriteLiteral("e=\"button\" value=\"Cancelar\" class=\"btn btn-sm btn-light\" data-bs-dismiss=\"modal\" />\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n   \r\n\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        function mostrarModal() {\r\n        new bootstrap.Modal($(\"#modal\"), {}).show();    }\r\n\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<MonitoringTemograficApplication.Models.Measurements>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
