#pragma checksum "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "986f6935e9b87e1164d1504161ac4065e64421cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\_ViewImports.cshtml"
using MovieMVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\_ViewImports.cshtml"
using MovieMVCApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\_ViewImports.cshtml"
using MovieMVCApp.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986f6935e9b87e1164d1504161ac4065e64421cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210b973e1deef775f0ffa364009742e304e1c887", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    var requestCultureFeature = Context.Features.Get<IRequestCultureFeature>();
    var requestCulture = requestCultureFeature.RequestCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>



<h1>Hello Live Reload!</h1>

<table class=""table culture-table"">
    <tr>
        <td style=""width:50%;"">Culture</td>
        <td>");
#nullable restore
#line 22 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml"
       Write(requestCulture.Culture.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" {");
#nullable restore
#line 22 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml"
                                            Write(requestCulture.Culture.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("}</td>\r\n    </tr>\r\n    <tr>\r\n        <td>UI Culture</td>\r\n        <td>");
#nullable restore
#line 26 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml"
       Write(requestCulture.UICulture.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>UICulture Parent</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml"
       Write(requestCulture.UICulture.Parent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Date</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml"
       Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Currency</td>\r\n        <td>\r\n            ");
#nullable restore
#line 39 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml"
        Write(12345.00.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>Number</td>\r\n        <td>\r\n            ");
#nullable restore
#line 45 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\MovieMVCApp\Views\Home\Index.cshtml"
        Write(123.45m.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
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
