#pragma checksum "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7ed9152230ad74431767d96f775fedae9b1499e"
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
#line 1 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ed9152230ad74431767d96f775fedae9b1499e", @"/Views/Processor/MeasurementExist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2997e580c9b6263be232350ff96c15338f4a78e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Processor_MeasurementExist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MonitoringTemograficApplication.Models.Measurements>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
  
    ViewData["Title"] = "MeasuremntExist";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 13 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                              Write(TempData["MSG_S"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""page-wrapper"">

    <div class=""page-breadcrumb"">
        <div class=""row"">
            <div class=""col-5 align-self-center"">
                <h4 class=""page-title"">Dados Existentes  </h4>
            </div>

        </div>
    </div>

    <div class=""container-fluid"">
        <div class=""row"">
            <div>
                <div class=""card"">
                    <div class=""card-body"">


");
#nullable restore
#line 37 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                         if (Model.Count > 0)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class="" grid-margin stretch-card"">
                                <div class=""card"">

                                    <div class=""card-body"">

                                        <div style=""position:relative;"">
                                            <div style=""float:right;"">
                                                <buton style="" position: relative;top:-15px;"" class=""btn btn-success"" type=""button"" data-toggle=""modal"" data-target=""#ModalProcessar"">Processar </buton>

                                            </div>
                                        </div>



                                        <div class=""table-responsive"">
                                            <table class=""table"">
                                                <thead id=""TableIndex"">
                                                    <tr style=""color:white;"">
                                                        <th scope=""col"">ID das Imagens</th>");
            WriteLiteral(@"
                                                        <th scope=""col"">Data</th>
                                                        <th scope=""col"">Número da Panela</th>
                                                        <th scope=""col"">Vida da Panela</th>
                                                        <th scope=""col"">Número da Corrida</th>
                                                        <th scope=""col"">Localização</th>
                                                        <th> </th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
#nullable restore
#line 69 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                                                     foreach (Measurements measurements in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <!--MODAL DE EDITAR-->
                                                        <div id=""modal"" class=""modal fade"" role=""dialog"">
                                                            <div class=""modal-dialog"">
                                                                <div class=""modal-content"">
                                                                    <div class=""modal-header"">
                                                                        <h6 class=""modal-title"">Edição de Dados</h6>
                                                                    </div>
                                                                    <div class=""modal-body"">

                                                                        <input type=""hidden"" class=""form-control form-control-sm MeasurementKey"" />
                                                                        <input type=""hidden"" class=""form-control form-con");
            WriteLiteral(@"trol-sm Time"" />
                                                                        <input type=""hidden"" class=""form-control form-control-sm Location"" />
                                                                        <input type=""hidden"" class=""form-control form-control-sm LadleAgeValidate"" />
                                                                        <input type=""hidden"" class=""form-control form-control-sm LadleIDValidate"" />


                                                                        <div class=""form-group"">

                                                                            <label>Número da Panela</label>
                                                                            <input type=""text"" class=""form-control form-control-sm LadleID"" />
                                                                            <span class=""text-danger erroID d-none""></span>
                                                                        </div>
");
            WriteLiteral(@"
                                                                        <div class=""form-group"">
                                                                            <label>Vida da Panela</label>
                                                                            <input type=""text"" class=""form-control form-control-sm LadleAge"" />
                                                                            <span class=""text-danger erroAge d-none""></span>
                                                                        </div>

                                                                        <div class=""form-group"">
                                                                            <label>Número da Corrida</label>
                                                                            <input type=""text"" class=""form-control form-control-sm RaceNumber"" />
                                                                            <span class=""text-danger erroRace");
            WriteLiteral(@" d-none""></span>
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
                 ");
            WriteLiteral("                                       </div>\r\n");
            WriteLiteral(@"                                                        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                                            <div class=""modal-dialog"" role=""document"">
                                                                <div class=""modal-content"">
                                                                    <div class=""modal-header"">
                                                                    </div>
                                                                    <div class=""modal-body"">
                                                                        <span>
                                                                            <p>
                                                                                Confirmar exclusão?
                                                                            </p>
                                  ");
            WriteLiteral(@"                                      </span>
                                                                    </div>
                                                                    <div class=""modal-footer"">
                                                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                                                                        <button type=""button"" class=""btn btn-danger""");
            BeginWriteAttribute("onclick", " onclick=\"", 8417, "\"", 8463, 3);
            WriteAttributeValue("", 8427, "Remove(", 8427, 7, true);
#nullable restore
#line 135 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
WriteAttributeValue("", 8434, measurements.MeasurementKey, 8434, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8462, ")", 8462, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Excluir</button>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
");
            WriteLiteral(@"                                                        <div class=""modal fade"" id=""ModalProcessar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                                            <div class=""modal-dialog"" role=""document"">
                                                                <div class=""modal-content"">
                                                                    <div class=""modal-header"">
                                                                    </div>
                                                                    <div class=""modal-body"">
                                                                        <span>
                                                                            <p>

                                                                            </p>
                                                                        </span>
                                                  ");
            WriteLiteral(@"                  </div>
                                                                    <div class=""modal-footer"">
                                                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                                                                        <button type=""button"" class=""btn btn-danger"">Confirmar</button>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
");
            WriteLiteral("                                                        <tr id=\"TableHv\" style=\"text-align:center;\">\r\n                                                            <td>");
#nullable restore
#line 166 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                                                           Write(measurements.MeasurementKey.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 167 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                                                           Write(measurements.Time.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 168 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                                                           Write(measurements.LadleID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 169 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                                                           Write(measurements.LadleAge.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 170 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                                                           Write(measurements.RaceNumber.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 171 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                                                           Write(measurements.Location.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                                                            <td id=""icons-edition"">
                                                                <div>
                                                                    <i id=""inputexist"" class=""me-2 mdi mdi-lead-pencil""");
            BeginWriteAttribute("onclick", " onclick=\"", 11504, "\"", 11565, 3);
            WriteAttributeValue("", 11514, "pegarMeasurmentPeloId(", 11514, 22, true);
#nullable restore
#line 175 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
WriteAttributeValue("", 11536, measurements.MeasurementKey, 11536, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11564, ")", 11564, 1, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                                                </div>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"                                                                <div>
                                                                    <i id=""inputexist"" class=""me-2 mdi mdi-delete"" data-toggle=""modal"" data-target=""#exampleModal""></i>
                                                                </div>


");
            WriteLiteral("                                                            </td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 195 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </tbody>\r\n\r\n                                            </table>\r\n                                            <div id=\"DivBtn\">\r\n                                                ");
#nullable restore
#line 200 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                                           Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("MeasurementExist", new { page = page, search = pesquisa }), new PagedListRenderOptions
                                            {
                                            LiElementClasses = new string[] { "page-item" },
                                            PageClasses = new string[] { "btn btn-outline-success text-right" }
                                            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 210 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""table-responsive"">
                                <table class=""table "">
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
#line 230 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\MeasurementExist.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $("".btn-cancel"").click(function() {
            location.reload(true)
        });
        function mostrarModal() {
            console.log(""teste"")
            try {

                $('#modal').modal('show');

            }
            catch (err) {
                console.log(err)
            }

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
 ");
                WriteLiteral(@"                   $("".LadleIDValidate"").val(measurent.ladleID);
                    $("".RaceNumber"").val(measurent.raceNumber);
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
            // REQUISIÇÃO AJAX  QUE ");
                WriteLiteral(@"REALIZA A COMUNICAÇÃO COMO BACKEND
            $.ajax({
                url: ""Edit"",
                method: 'PUT',
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
            let AgeValid = ValidarAge(Measure");
                WriteLiteral(@"ment.LadleAge);
            let validaId = ValiditId(Measurement.LadleID);
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
            if (parseInt(Measur");
                WriteLiteral(@"ement.LadleAge) == parseInt(Measurement.LadleAgeValidate) && parseInt(Measurement.LadleID) != parseInt(Measurement.LadleIDValidate)) {
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
        ");
                WriteLiteral(@"    }
            return ageValida;
        }
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
                $("".erroRace"").removeClass(""d-non");
                WriteLiteral(@"e"");
                RaceValidt = false;
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
