#pragma checksum "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\Photo\PictureGallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e22c9d3b51899a2dc707b604ee481755a14722e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photo_PictureGallery), @"mvc.1.0.view", @"/Views/Photo/PictureGallery.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\_ViewImports.cshtml"
using NET5MVC_RazorSamples;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\_ViewImports.cshtml"
using NET5MVC_RazorSamples.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\_ViewImports.cshtml"
using NET5MVC_RazorSamples.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\_ViewImports.cshtml"
using NET5MVC_RazorSamples.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e22c9d3b51899a2dc707b604ee481755a14722e", @"/Views/Photo/PictureGallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883341c8ea6b19e32a7c8a69a6559fea7f912878", @"/Views/_ViewImports.cshtml")]
    public class Views_Photo_PictureGallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\Photo\PictureGallery.cshtml"
  
    ViewData["Title"] = "PictureGallery";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PictureGallery</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\Photo\PictureGallery.cshtml"
 foreach(string currentPicturePath in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e22c9d3b51899a2dc707b604ee481755a14722e4664", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 201, "~/images/", 201, 9, true);
#nullable restore
#line 11 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\Photo\PictureGallery.cshtml"
AddHtmlAttributeValue("", 210, System.IO.Path.GetFileName(currentPicturePath), 210, 47, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\Photo\PictureGallery.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
