#pragma checksum "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a7c1d7202d4104cb01b1ed9810b8f1ab4e5a38e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Processor_Index), @"mvc.1.0.view", @"/Views/Processor/Index.cshtml")]
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
#line 1 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a7c1d7202d4104cb01b1ed9810b8f1ab4e5a38e", @"/Views/Processor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2997e580c9b6263be232350ff96c15338f4a78e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Processor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MonitoringTemograficApplication.Models.TB_EXT_LD_LOG>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Alterações Processadas</h1>\r\n\r\n<br />\r\n<br />\r\n<!--\r\n    Formulário\r\n    -- QueryString: Colaborador/Cliente/Index?pesquisa={palavraDigitada}&pagina=3\r\n-->\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 29 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"display: flex; justify-content: flex-end\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a7c1d7202d4104cb01b1ed9810b8f1ab4e5a38e6065", async() => {
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
#line 37 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
 if (Model.Count > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table class=""table   table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Data Alteração</th>
                    <th scope=""col"">Corrida</th>
                    <th scope=""col"">Panela</th>
                    <th scope=""col"">Usuário</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 51 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
                 foreach (TB_EXT_LD_LOG process in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 54 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
                       Write(process.dProcessor.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
                       Write(process.cHeatNo.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
                       Write(process.nLdNo.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
                       Write(process.cUser.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 63 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div style=\"display: flex; justify-content: flex-end\">\r\n        ");
#nullable restore
#line 68 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page = page, search = pesquisa }), new PagedListRenderOptions
    {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "page-link" }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 74 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"


}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""table-responsive"">
    <table class=""table table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">Data Alteração</th>
                <th scope=""col"">Corrida</th>
                <th scope=""col"">Panela</th>
                <th scope=""col"">Usuário</th>
            </tr>
        </thead>
    </table>
    <div>
        Nenhum registro cadastrado!
    </div>
</div>
");
#nullable restore
#line 94 "C:\Program Files (x86)\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Index.cshtml"
    
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<MonitoringTemograficApplication.Models.TB_EXT_LD_LOG>> Html { get; private set; }
    }
}
#pragma warning restore 1591
