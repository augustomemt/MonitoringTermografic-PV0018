#pragma checksum "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed0b3f9a646740663d4bd12439e977dcf9020799"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Processor_Report), @"mvc.1.0.view", @"/Views/Processor/Report.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed0b3f9a646740663d4bd12439e977dcf9020799", @"/Views/Processor/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2997e580c9b6263be232350ff96c15338f4a78e4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Processor_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MonitoringTemograficApplication.Models.Measurements>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\NovoCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Processor\Report.cshtml"
  
    ViewData["Title"] = "Report";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-wrapper"">
    <div class=""page-breadcrumb"">
        <div class=""row"">
            <div class=""col-5 align-self-center"">
                <h4 class=""page-title""> Relatório Monitoramento Termográfico </h4>
            </div>

        </div>
    </div>

    <div class=""container-fluid"">
        <div class=""row"">
            <div>
                <div class=""card"">
                    <div class=""card-body"">
                        <div class="" grid-margin stretch-card"">
                            <div class=""card"">
                                <div class=""card-body"">

                                    <div id=""reports-filters"" class=""row"" style=""margin-bottom:0;"">
                                        <div class=""col-md-12 top-33"">
                                        </div>
                                        <div class=""col-md-12"" style=""padding:0;right:18px;position:relative;"">
                                            <div class=""col-md-12 space-20"" s");
            WriteLiteral(@"tyle=""margin-top:30px;"">
                                                <div id=""DataIni"" class=""col-sm-2"">
                                                    <label><b>Data Inicio</b></label>
                                                    <input name=""startDate"" type=""date"" class=""form-control dateStart"" maxlength=""8"" required />

                                                </div>
                                                <div id=""DataFim"" class=""col-sm-2"">
                                                    <label><b>Data final</b></label>
                                                    <input name=""endDate"" type=""date"" class=""form-control dateEnd"" maxlength=""8"" required />
                                                </div>
                                                <div id=""GeraRelat"" >

                                                    <div style=""position:relative; top:30px;"">
                                                        <input type=""button"" value=""");
            WriteLiteral(@"Gerar Relatório"" class=""btn btn-success  btnGerar"" />
                                                    </div>
                                                    <div id=""btnexport"">
                                                        <input  id=""inpexport"" type=""button"" value=""Exportar"" class=""btn btn-success   btnExport"" />
                                                    </div>
                                                  
                                                    
                                                </div>


                                                <div class=""col-md-12"" style=""margin-top:5px;"">
                                                    <label id=""error_endDate"" style=""color: red;font-weight:bold;""> </label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-md-12 title-container"" s");
            WriteLiteral(@"tyle=""border-radius:5px;height:50px;"">
                                            <div class=""col-md-10"" style=""margin-top:8px;float:right;padding:0;display: flex;align-items: center;"">
                                                <div class=""dropdown col-sm-1"" style=""margin-right:9px;float:right;padding:0;"">

                                                    <div class=""dropdown-menu export-pannel"" style=""margin-left:-80px;"">
                                                        <h4>Formato</h4>
                                                        <ul class="" space-30"">
                                                            <!--<li class=""btn btn-default"" style=""width: 100%;""> <a class=""dropdown-item"" id=""btn-export-pdf"" href=""/url/"">PDF</a></li>-->
                                                            <li class=""btn btn-default"" style=""width: 100%""> <a class=""dropdown-item"" id=""btn-export-xls"" href=""/url/"">XLSX</a></li>
                                                        <");
            WriteLiteral(@"/ul>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <br />
                                    <div class=""table-responsive"" id=""DivTbReport"">
                                        <table class=""table"">
                                            <thead id=""TableIndex"">
                                                <tr id=""table-column"" style=""text-align:center;font-size:15px;color: black;"">
                                                </tr>
                                            </thead>
                                            <tbody id=""table-content"" style=""text-align:center;padding-right: 30px;"">
                                            </tbody>
                                        </table>
                                    ");
            WriteLiteral(@"    <nav class=""text-center"" id=""pagination"" style=""font-size:10px;position:relative;top:3px;"">

                                        </nav>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <
</div>






");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        $('#btnexport').hide();
        var pageNumber = 1
        var size = 10
        var numberOfPages = 0
        $("".btnGerar"").click(function() {

            console.log(pageNumber)
            var dateRange = {

                dateStart: $('.dateStart').val(),
                dateEnd: $('.dateEnd').val(),
                page: pageNumber
            };

            if (Validate(dateRange)) {
                ReportGenerate(dateRange)
                    ;


            }

        });

        function Generate() {
            var dateRange = {
                dateStart: $('.dateStart').val(),
                dateEnd: $('.dateEnd').val(),
                page: pageNumber

            };

            if (Validate(dateRange)) {
                ReportGenerate(dateRange)


            }
        }

        function Gerar(event) {
            if (event) {
                event.preventDefaut()
            }
            var dateRange = {

         ");
                WriteLiteral(@"       dateStart: $('.dateStart').val(),
                dateEnd: $('.dateEnd').val(),
            };

            if (Validate(dateRange)) {
                ReportGenerate(dateRange)

            }
        }

        function ReportGenerate(dateRange) {
            $.ajax({
                url: ""PostReport"",
                data: dateRange,
                cache: false,
                success: function(response) {
                    console.log(response)
                    DrawTable(response.measurements)
                    numberOfPages = response.totalPages
                    console.log(numberOfPages);
                    updatePagination()

                }
            });

        }
        function DrawTable(response) {
            console.log(response)

            var html = ''

            for (var i = 0; i < response.length; i++) {
                html +=
                    ""<tr id='TextReport' style='font-size:15px;padding-left:5000px'>"" +
                 ");
                WriteLiteral(@"   ""<td>"" + response[i].measurementKey + ""</td>"" +
                    ""<td>"" + response[i].time.slice(0, 19).replaceAll(""-"", ""/"").replaceAll(""T"", "" "") + ""</td>"" +
                    ""<td>"" + response[i].ladleID + ""</td>"" +
                    ""<td>"" + response[i].ladleAge + ""</td>"" +
                    ""<td>"" + response[i].raceNumber + ""</td>"" +
                    ""<td>"" + response[i].ladleDescription + ""</td>"" +
                    ""<td>"" + response[i].origin + ""</td>"" +
                    ""<td>"" + response[i].location + ""</td>"" +
                    ""</tr>""
            }



            console.log(html);
            var column = ""<th scope='col' >"" + 'ID das Imagens' + ""</th>"" +
                ""<th scope='col' >"" + ""Data"" + ""</th>"" +
                ""<th scope='col' >"" + ""Número da Panela"" + ""</th>"" +
                ""<th scope='col'>"" + ""Vida da Panela"" + ""</th>"" +
                ""<th scope='col' >"" + ""Número da corrida"" + ""</th>"" +
                ""<th scope='col' >"" + ""Descrição");
                WriteLiteral(@" da panela"" + ""</th>"" +
                ""<th scope='col' >"" + ""Rota"" + ""</th>"" +
                ""<th scope='col' >"" + ""Localização"" + ""</th>""

            var columnempty = ""Dados Inexistentes""
            if (response.length == 0) {
                $('#table-column').html(columnempty)
                $('#table-content').html(html)
                $("".btnExport"").prop('disabled', true)
                $('#btnexport').hide();
            } else {
                $('#btnexport').show();
                $('#table-column').html(column)
                $("".btnExport"").prop('disabled', false)
                $('#table-content').html(html)
                updatePagination();
            }


        }
        function Validate(dateRange) {
            if (dateRange.dateStart === """" || dateRange.dateEnd === """") {
                $(""#error_endDate"").html(""A Data deve ser preenchida"")
                return false
            }
            if (dateRange.dateStart.length > 10 || dateRange.dateEnd");
                WriteLiteral(@".length > 10) {
                $(""#error_endDate"").html(""Verifique a data informada. "")
                console.log(dateRange.dateStart.count())
                return false
            }
            else {
                if (dateRange.dateStart > dateRange.dateEnd) {
                    $(""#error_endDate"").html(""A Data Final deve ser maior que a Data Inicial."")
                    return false
                }
                return true

            }

        }
        $("".btnExport"").click(function() {

            var dateRange = {
                dateStart: $('.dateStart').val(),
                dateEnd: $('.dateEnd').val(),
            };
            ExportExcel(dateRange)

        });
        function ExportExcel(dateRange) {

            var data = ""ExportXlsx?dateStart="" + dateRange.dateStart + ""&"" + ""dateEnd="" + dateRange.dateEnd;
            var request = new XMLHttpRequest();
            request.open('GET', data, true);
            request.setRequestHeader('Content");
                WriteLiteral(@"-Type', 'application/x-www-form-urlencoded; charset=UTF-8');
            request.responseType = 'blob';

            request.onload = function(e) {
                if (this.status === 200) {
                    var blob = this.response;
                    if (window.navigator.msSaveOrOpenBlob) {
                        window.navigator.msSaveBlob(blob, ""monitoramentotermograficos.xlsx"");
                    }
                    else {
                        var downloadLink = window.document.createElement('a');
                        var contentTypeHeader = request.getResponseHeader(""Content-Type"");
                        downloadLink.href = window.URL.createObjectURL(new Blob([blob], { type: contentTypeHeader }));
                        var d = new Date().toISOString().slice(0, 19).replaceAll('-', '').replaceAll('T', '').replaceAll(':', '');
                        console.log(d);
                        downloadLink.download = d + ""-MonitoramentoTermografico.xlsx"";
                    ");
                WriteLiteral(@"    document.body.appendChild(downloadLink);
                        downloadLink.click();
                        document.body.removeChild(downloadLink);
                    }
                }
            };
            console.log(data);
            request.send(data);




        }

        $(document).ready(function() {

            $("".btnExport"").prop('disabled', true);

        });

        $(""#reports-filters"").on('submit', function(event) {
            console.log('banana')
            try {
                Gerar(event)
            }
            catch (err) {
                console.log(err)
            }

        })

        function changePage(_page, set) {

            if (set) {
                pageNumber = _page
            } else {
                pageNumber += _page
            }

            if (pageNumber < 1) {
                pageNumber = 1
            } else {
                Generate()
            }
            updatePagination()
        }
");
                WriteLiteral(@"        function updatePagination() {
            var tagetDiv = '#pagination'

            var paginationHTML = '<ul class=""pagination justify-content-end "">'

            if (pageNumber > 1) {
                paginationHTML +=
                    '<li  class=""page-item"">' +
                    '<span  class=""btn btn-outline-success text-right"" disabled onclick=""changePage(-1)"">Anterior</span>' +
                    '</li>'
            }

            for (var i = 0; i < numberOfPages; i++) {
                var currentPage = i + 1
                var isCurrentPage = pageNumber === currentPage

                if (currentPage <= 3 || currentPage >= (numberOfPages - 3) || (currentPage <= (pageNumber + 3) && currentPage >= (page - 3))) {

                    paginationHTML +=
                        '<li  class=""page-item  ' + (isCurrentPage ? 'active' : '') + '"">' +
                        '<span  class="" btn btn-outline-success text-right"" onclick=""changePage(' + currentPage + ', true)""> '");
                WriteLiteral(@" + currentPage + '  </span>' +
                        '</li>'

                } else if (currentPage === 4) {
                    paginationHTML +=
                        '<li class=""page-item "">' +
                        '<span class=""btn btn-success text-right""  > ...  </span>' +
                        '</li>'
                } else if (currentPage === (numberOfPages - 4)) {
                    paginationHTML +=
                        '<li class=""page-item "">' +
                        '<span class=""""btn btn-outline-success text-right""  > ...  </span>' +
                        '</li>'
                }
            }

            if (pageNumber < numberOfPages) {
                paginationHTML +=
                    '<li class=""page-item"">' +
                    '<span class=""btn btn-outline-success text-right "" disabled href=""#"" onclick=""changePage(1)"" value="""">Próximo</span>' +
                    '</li>' +
                    '</ul>'
            }

            console.log(pa");
                WriteLiteral("ginationHTML);\r\n            $(tagetDiv).html(paginationHTML)\r\n        }\r\n\r\n\r\n\r\n\r\n    </script>\r\n            ");
            }
            );
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
