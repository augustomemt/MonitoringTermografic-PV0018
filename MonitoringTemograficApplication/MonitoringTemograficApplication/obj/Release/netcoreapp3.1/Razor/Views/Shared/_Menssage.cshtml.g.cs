#pragma checksum "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eebcc349f995e138c3a45f5c0a2a766423eeb04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Menssage), @"mvc.1.0.view", @"/Views/Shared/_Menssage.cshtml")]
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
#line 1 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using MonitoringTemograficApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eebcc349f995e138c3a45f5c0a2a766423eeb04", @"/Views/Shared/_Menssage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2997e580c9b6263be232350ff96c15338f4a78e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Menssage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"UTF-8\">\r\n");
#nullable restore
#line 2 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
 if (ViewData["MSG_E"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <!-- Button trigger modal -->
  <!-- Modal -->
  <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h5 class=""modal-title"" id=""exampleModalLabel""> 🚫</h5>
          <h5 class=""modal-title"" id=""exampleModalLabel"">Não autorizado</h5>
          <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
          </button>
        </div>
        <div class=""modal-body"">
          <p> '");
#nullable restore
#line 17 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
          Write(Html.Raw(ViewData["MSG_E"].ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'</p>\r\n\r\n        </div>\r\n        <div class=\"modal-footer\">\r\n\r\n\r\n\r\n          <button type=\"button\" class=\"btn btn-primary\" data-dismiss=\"modal\">Ok</button>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n");
            WriteLiteral("  <script>\r\n    $(document).ready(function () {\r\n      $(\"#exampleModal\").modal({\r\n        show: true\r\n      });\r\n    })\r\n  </script>\r\n");
#nullable restore
#line 40 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"


}

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
 if (TempData["MSG_E"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p class=\"alert alert-danger\">");
#nullable restore
#line 45 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
                           Write(Html.Raw(TempData["MSG_E"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 46 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
 if (ViewData["MSG_A"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"alert alert-danger\">\'");
#nullable restore
#line 50 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
                          Write(Html.Raw(ViewData["MSG_A"].ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'</p>\r\n");
#nullable restore
#line 51 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
 if (ViewData["MSG_S"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p class=\"alert alert-danger\">");
#nullable restore
#line 56 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
                           Write(Html.Raw(TempData["MSG_E"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 57 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
 if (TempData["MSG_S"] != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("  <p class=\"alert alert-success\">");
#nullable restore
#line 61 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
                            Write(Html.Raw(TempData["MSG_S"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 62 "C:\featurevidapanela01\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Views\Shared\_Menssage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
