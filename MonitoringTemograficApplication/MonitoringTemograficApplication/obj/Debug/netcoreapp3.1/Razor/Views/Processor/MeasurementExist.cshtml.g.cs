#pragma checksum "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01a83d230d78a8e917e22873646eb810a6a7970b"
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
#line 1 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01a83d230d78a8e917e22873646eb810a6a7970b", @"/Views/Processor/MeasurementExist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2997e580c9b6263be232350ff96c15338f4a78e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Processor_MeasurementExist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MonitoringTemograficApplication.Models.Measurements>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:25px; height:25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrapicons/pencil-square.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrapicons/trash-fill.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
  
    ViewData["Title"] = "MeasuremntExist";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 style=\"text-align:center; \">Alterações Processadas</h1>\r\n\r\n<br />\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 14 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 16 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n");
#nullable restore
#line 21 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
 if (Model.Count > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsivez"" id=""DivTb"">
        <table class=""table  table-bordered"">
            <thead id=""TableIndex"">
                <tr style=""color:white;"">
                    <th scope=""col"" id=""TableHv"">ID das Imagens</th>
                    <th scope=""col"">Data</th>
                    <th scope=""col"">Número da Panela</th>
                    <th scope=""col"">Vida da Panela</th>
                    <th scope=""col"">Número da Corrida</th>
                    <th scope=""col"">Localização</th>
                    <th style=""width:20px;""> </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 38 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                 foreach (Measurements measurements in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr id=\"TableHv\">\r\n                        <td>");
#nullable restore
#line 41 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.MeasurementKey.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.Time.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.LadleID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.LadleAge.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.RaceNumber.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n");
            WriteLiteral("\r\n                        <td style=\"width:85px;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01a83d230d78a8e917e22873646eb810a6a7970b10377", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1813, "pegarMeasurmentPeloId(", 1813, 22, true);
#nullable restore
#line 50 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
AddHtmlAttributeValue("", 1835, measurements.MeasurementKey, 1835, 28, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1863, ")", 1863, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01a83d230d78a8e917e22873646eb810a6a7970b12336", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2160, "Remove(", 2160, 7, true);
#nullable restore
#line 52 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
AddHtmlAttributeValue("", 2167, measurements.MeasurementKey, 2167, 28, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2195, ")", 2195, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n        <div id=\"DivBtn\">\r\n            ");
#nullable restore
#line 60 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("MeasurementExist", new { page = page, search = pesquisa }), new PagedListRenderOptions
        {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "btn btn-outline-success text-right" }
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""table-responsive"">
        <table class=""table table-bordered"">
            <thead id=""TableIndex"">
                <tr>
                    <th scope=""col"">ID das Imagens</th>
                    <th scope=""col"">Data</th>
                    <th scope=""col"">Número da Panela</th>
                    <th scope=""col"">Vida Panela</th>
                    <th scope=""col"">Número da Corrida</th>
                    <th scope=""col"">Localização</th>
                </tr>
            </thead>
        </table>
        <div>
            Nenhum registro cadastrado!
        </div>
    </div>
");
#nullable restore
#line 87 "C:\AtualizadoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
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
                <input type=""hidden"" class=""form-control form-control-sm Time"" />
                <input type=""hidden"" class=""form-control form-control-sm Location"" />
                <input type=""hidden"" class=""form-control form-control-sm LadleAgeValidate"" />
                <input type=""hidden"" class=""form-control form-control-sm LadleIDValidate"" />


                <div class=""form-group"">

                    <label>Número da Panela</label>
                    <input type=""text"" class=""form-control form-control-sm LadleID"" />
                    <span class=""text-danger erroID d-none""></span>
                </div>

                <div ");
            WriteLiteral(@"class=""form-group"">
                    <label>Vida da Panela</label>
                    <input type=""text"" class=""form-control form-control-sm LadleAge"" />
                    <span class=""text-danger erroAge d-none""></span>
                </div>

                <div class=""form-group"">
                    <label>Número da Corrida</label>
                    <input type=""text"" class=""form-control form-control-sm RaceNumber"" />
                    <span class=""text-danger erroRace d-none""></span>
                </div>
            </div>

            <div class=""modal-footer"">
                <div class=""form-group"">
                    <input type=""button"" value=""Salvar"" class=""btn btn-sm btn-outline-success btnSalvar"" />
                    <input type=""button"" value=""Cancelar"" class=""btn btn-sm btn-cancel"" data-bs-dismiss=""modal"" />
                </div>
            </div>

        </div>

    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        $("".btn-cancel"").click(function() {
            location.reload(true)
        });

        function mostrarModal() {
            $('#modal').modal({
                show: true
            });
        };
        // FUNÇÃO RESPONSAVEL POR PEGAR OS DADOS PELO ID
        function pegarMeasurmentPeloId(MeasurmentId) {

            $.ajax({
                url: ""GetId"",
                method: 'GET',
                data: {
                    id: MeasurmentId
                },
                success: function(measurent) {
                    console.log(measurent)
                    mostrarModal();
                    $("".MeasurementKey"").val(measurent.measurementKey);
                    $("".LadleAge"").val(measurent.ladleAge);
                    $("".LadleAgeValidate"").val(measurent.ladleAge);
                    $("".LadleID"").val(measurent.ladleID);
                    $("".LadleIDValidate"").val(measurent.ladleID);
                    $("".RaceNumber"").val(mea");
                WriteLiteral(@"surent.raceNumber);
                    $("".Time"").val(measurent.time);
                    $("".Location"").val(measurent.location);
                }
            })
        }





        $("".btnSalvar"").click(function() {
            var Measurement = {
                MeasurementKey: $('.MeasurementKey').val(),
                LadleAge: $('.LadleAge').val(),
                LadleID: $('.LadleID').val(),
                RaceNumber: $('.RaceNumber').val(),
                Time: $('.Time').val(),
                Location: $('.Location').val(),
                LadleAgeValidate: $('.LadleAgeValidate').val(),
                LadleIDValidate: $('.LadleIDValidate').val()
            }
            if (ValidarFormulario(Measurement)) {
                UpdateMeasruremnt(Measurement)

            }

        });


        function UpdateMeasruremnt(Measruremnt) {

            // REQUISIÇÃO AJAX  QUE REALIZA A COMUNICAÇÃO COMO BACKEND
            $.ajax({
                url: ""Edit"",
  ");
                WriteLiteral(@"              method: 'PUT',
                data: {
                    Measruremnt01: Measruremnt
                },
                success: function(Measruremnt) {
                    $(""#modal"").modal('hide');
                    console.log(""modal fecha agora "")
                    location.reload(true)


                }
            });
        }


        function Remove(MeasurementKey) {

            $.ajax({
                url: ""Delete"",
                method: 'DELETE',
                data: {
                    MeasurementKey: MeasurementKey

                },
                success: function(Measruremnt) {
                    $(""#modal"").modal('hide');
                    console.log(""modal fecha agora "")
                    location.reload(true)

                }
            });


        }

        function ValidarFormulario(Measurement) {

            let AgeValid = ValidarAge(Measurement.LadleAge);
            let validaId = ValiditId(Measurement.La");
                WriteLiteral(@"dleID);
            let validaRace = ValidarRace(Measurement.RaceNumber);
            let validarCompar = ValidarCompare(Measurement);
            console.log(validarCompar);

            console.log(""Meu valor idade"" + Measurement)
            if (AgeValid == true && validaId == true && validaRace == true && validarCompar == true)
                return true;

            return false;

        }

        function ValidarCompare(Measurement) {

            console.log(Measurement)
            let result = true
            if (parseInt(Measurement.LadleAge) != parseInt(Measurement.LadleAgeValidate) && parseInt(Measurement.LadleID) == parseInt(Measurement.LadleIDValidate)) {
                $("".LadleID"").addClass('is-invalid');
                $("".erroID"").text(""É necessário altera o número da panela"");
                $("".erroID"").removeClass(""d-none"");
                result = false;

            }
            if (parseInt(Measurement.LadleAge) == parseInt(Measurement.LadleAgeValidate");
                WriteLiteral(@") && parseInt(Measurement.LadleID) != parseInt(Measurement.LadleIDValidate)) {
                $("".LadleAge"").addClass('is-invalid');
                $("".erroAge"").text(""É necessário alterar a vida da panela"");
                $("".erroAge"").removeClass(""d-none"");
                result = false;
            }
            return result

        }

        function ValidarAge(LadleAge) {

            let ageValida = true;

            if (isNaN(LadleAge) || LadleAge == undefined || LadleAge == """") {
                $("".LadleAge"").addClass('is-invalid');
                $("".erroAge"").text(""Preencha a vida da panela"");
                $("".erroAge"").removeClass(""d-none"");
                ageValida = false;


            }
            else {
                $("".LadleAge"").removeClass('is-invalid');
                $("".erroAge"").addClass('is-valid'); -
                    $("".erroAge"").addClass(""d-none"");
                ageValida = true;
            }
            return ageValida;

    ");
                WriteLiteral(@"    }
        function ValiditId(LadleID) {
            let IdValidit = true

            if (isNaN(LadleID) || LadleID == undefined || LadleID == """") {
                $("".LadleID"").addClass('is-invalid');
                $("".erroID"").text(""Preencha o número da panela"");
                $("".erroID"").removeClass(""d-none"");

                IdValidit = false;
            }

            else {
                $("".LadleID"").removeClass('is-invalid');
                $("".erroID"").addClass('is-valid');
                $("".erroID"").addClass(""d-none"");

                IdValidit = true;
            }
            return IdValidit;

        }
        function ValidarRace(RaceNumber) {
            let RaceValidt = true;

            if (RaceNumber.trim() == '' || RaceNumber == undefined) {
                $("".RaceNumber"").addClass('is-invalid');
                $("".erroRace"").text(""Preencha o número da corrida"");
                $("".erroRace"").removeClass(""d-none"");
                RaceVali");
                WriteLiteral(@"dt = false;
            }
            else {
                $("".RaceNumber"").removeClass('is-invalid');
                $("".erroRace"").addClass('is-valid');
                $("".erroRace"").addClass(""d-none"");

                RaceValidt = true;
            }
            return RaceValidt;

        }


    </script>

");
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
