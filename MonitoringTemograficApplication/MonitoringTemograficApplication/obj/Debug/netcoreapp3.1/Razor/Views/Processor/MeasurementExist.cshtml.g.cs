#pragma checksum "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1191d9f1612f3a15cd061bd41709c72aa605156"
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
#line 1 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1191d9f1612f3a15cd061bd41709c72aa605156", @"/Views/Processor/MeasurementExist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2997e580c9b6263be232350ff96c15338f4a78e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Processor_MeasurementExist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MonitoringTemograficApplication.Models.Measurements>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
  
    ViewData["Title"] = "MeasuremntExist";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 style=\"text-align:center; \">Alterações Processadas</h1>\r\n\r\n<br />\r\n<br />\r\n<!--\r\n    Formulário\r\n    -- QueryString: Colaborador/Cliente/Index?pesquisa={palavraDigitada}&pagina=3\r\n-->\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 28 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 29 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
}


#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 36 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
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
#line 51 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                 foreach (Measurements measurements in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 54 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.MeasurementKey.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.Time.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.LadleID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.LadleAge.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 58 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                       Write(measurements.RaceNumber.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button type=\"button\" class=\"btn btn-outline-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2088, "\"", 2149, 3);
            WriteAttributeValue("", 2098, "pegarMeasurmentPeloId(", 2098, 22, true);
#nullable restore
#line 59 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
WriteAttributeValue("", 2120, measurements.MeasurementKey, 2120, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2148, ")", 2148, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Atualizar</button></td>\r\n                    </tr>\r\n");
#nullable restore
#line 61 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div id=\"DivBtn\">\r\n            ");
#nullable restore
#line 65 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
       Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("MeasurementExist", new { page = page, search = pesquisa }), new PagedListRenderOptions
        {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "btn btn-outline-success text-right"}
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 72 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
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
#line 91 "C:\cspUpdate\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
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


                <div class=""form-group"">

                    <label>Numero Panela</label>
                    <input type=""text"" class=""form-control form-control-sm LadleID"" />
                    <span class=""text-danger erroProfissao d-NumeroPanela""></span>
                </div>

                <div class=""form-group"">
                    <label>Vida Panela</label>
                    <input type=""text"" class=""form-control form-control-sm LadleAge"" />
                    <");
            WriteLiteral(@"span class=""text-danger erroProfissao d-VidaPanela""></span>
                </div>

                <div class=""form-group"">
                    <label>NumeroCorrida</label>
                    <input type=""text"" class=""form-control form-control-sm RaceNumber"" />
                    <span class=""text-danger erroProfissao d-NumeroCorrida""></span>
                </div>
            </div>

            <div class=""modal-footer"">
                <div class=""form-group"">
                    <input type=""button"" value=""Salvar"" class=""btn btn-sm btn-outline-success btnSalvar"" />
                    <input type=""button"" value=""Cancelar"" class=""btn btn-sm btn-light"" data-bs-dismiss=""modal"" />
                </div>
            </div>

        </div>

    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function mostrarModal() {
            new bootstrap.Modal($(""#modal""), {}).show();
        }
        // FUNÇÃO RESPONSAVEL POR PEGAR OS DADOS PELO ID
        function pegarMeasurmentPeloId(MeasurmentId) {
            //  REQUISIÇÃO REPONSAVEL POR PEGAR
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
                    $("".LadleID"").val(measurent.ladleID);
                    $("".RaceNumber"").val(measurent.raceNumber);
                    $("".Time"").val(measurent.time);
                    //$("".Location"").val(measurent.location);
                    $("".Location"").val(measurent.location);
         ");
                WriteLiteral(@"       }
            })
        }
        // FUNÇÃO RESPONSAVEL POR SALVAR OS DADOS , PEGA  OS DADOS FO FORMULARIO
$("".btnSalvar"").click(function() {
    var Measurement = {
        MeasurementKey: $('.MeasurementKey').val(),
        LadleAge: $('.LadleAge').val(),
        LadleID: $('.LadleID').val(),
        RaceNumber: $('.RaceNumber').val(),
        Time: $('.Time').val(),
        Location: $('.Location').val()
    };
    // CHAMADA PA A FUNÇÃO QUE ATUALIZA DADOS

    UpdateMeasruremnt(Measurement)

    //var variavel = 5;
    //var variavel01 = 'Augusto'
    //var varivel02 = false
    //var variavel03 = 02 / 05 / 2019
    //var variavel04 = 5.2
    //var variavel05 = GetName()
    //var variavel06= ChamaCarro()

    //function string GetName(){
    //    return 'Augusto'
    //}

    //function Carro ChamaCarro(){

    //    var carro = {cor:'Preto', nome:'Palio'}

    //    return carro 
    //}


        });
        // FUNÇÃO QUE faz A REQUISIÇÃO COM O BACKEND E A");
                WriteLiteral(@"TUALIZA OS DADOS
        function UpdateMeasruremnt(Measruremnt) {
            // REQUISIÇÃO AJAX  QUE REALIZA A COMUNICAÇÃO COMO BACKEND
            $.ajax({
                url: ""Edit"",
                method: 'PUT',
                data: {
                    Measruremnt01: Measruremnt
                },
                success: function(Measruremnt) {
                    $(""#modal"").modal('hide');

                    location.reload(true)


                }
            });
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
