#pragma checksum "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\ASPMVC_DependencyInjection_ServiceCollection_Samples\Views\Home\ShowCar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af0d79df778980d778291ef2ec2d7bf777165d60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowCar), @"mvc.1.0.view", @"/Views/Home/ShowCar.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\ASPMVC_DependencyInjection_ServiceCollection_Samples\Views\_ViewImports.cshtml"
using ASPMVC_DependencyInjection_ServiceCollection_Samples;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\ASPMVC_DependencyInjection_ServiceCollection_Samples\Views\_ViewImports.cshtml"
using ASPMVC_DependencyInjection_ServiceCollection_Samples.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af0d79df778980d778291ef2ec2d7bf777165d60", @"/Views/Home/ShowCar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07de016bd17864aaf1775d19ddbc99f5d8f4f2c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowCar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPMVC_DependencyInjection_ServiceCollection_Samples.Services.Car>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\ASPMVC_DependencyInjection_ServiceCollection_Samples\Views\Home\ShowCar.cshtml"
  
    ViewData["Title"] = "ShowCar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ShowCar</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\ASPMVC_DependencyInjection_ServiceCollection_Samples\Views\Home\ShowCar.cshtml"
Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n");
#nullable restore
#line 11 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\ASPMVC_DependencyInjection_ServiceCollection_Samples\Views\Home\ShowCar.cshtml"
Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\ASPMVC_DependencyInjection_ServiceCollection_Samples\Views\Home\ShowCar.cshtml"
Write(Model.ConstructionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPMVC_DependencyInjection_ServiceCollection_Samples.Services.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591