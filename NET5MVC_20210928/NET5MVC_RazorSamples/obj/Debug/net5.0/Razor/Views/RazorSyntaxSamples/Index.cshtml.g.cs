#pragma checksum "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54393c77f6161fbbf3fae037927ef18106e93501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RazorSyntaxSamples_Index), @"mvc.1.0.view", @"/Views/RazorSyntaxSamples/Index.cshtml")]
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
#nullable restore
#line 226 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
using NET5MVC_RazorSamples.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54393c77f6161fbbf3fae037927ef18106e93501", @"/Views/RazorSyntaxSamples/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883341c8ea6b19e32a7c8a69a6559fea7f912878", @"/Views/_ViewImports.cshtml")]
    public class Views_RazorSyntaxSamples_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Person>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  
    ViewData["Title"] = "Index";

    int abvc = 123;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<p>Was ist Razor?</p>
<p>Ist ein TemplateSystem + M??glichkeiten, wie man Objecte in HTML am besten verwenden kann</p>

<p>Was ist ein Template-System in HTML?</p>
<p>Ein Templatesystem erm??glicht in HTML, Objekte via Platzhalter auszugeben und auch Formulare mit Objekte </p>

<p>Wie wird Razor verwendet-> Erstes Beispiel </p>
<p>Anzahl von Personen ");
#nullable restore
#line 19 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
                  Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral("<p>Ein [AT-]-Zeichen wird hier ausgegeben ");
            WriteLiteral("@Model.Count</p>\r\n\r\n");
            WriteLiteral("<p>");
#nullable restore
#line 25 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 26 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
Write(DateTime.IsLeapYear(2016));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral("\r\n<p>Last week this time: ");
#nullable restore
#line 30 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
                    Write( DateTime.Now - TimeSpan.FromDays(7)  );

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 32 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  
    //Diese Person die hier angelegt wurde, gilt nur auf dieser View
    Person person = new Person("Grimm", 50);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 37 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 38 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
Write(person.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 39 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
Write(person.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n<p>Age: ");
#nullable restore
#line 42 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
   Write(person.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral("\r\n<p>");
#nullable restore
#line 52 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
Write(GenericMethod<int>());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 64 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
Write(Html.Raw("<b>Hello World</b>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  

    void RenderName(string name)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Name: <strong>");
#nullable restore
#line 83 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
                    Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n");
#nullable restore
#line 84 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
    }

    RenderName("Mahatma Gandhi");
    RenderName("Martin Luther King, Jr.");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 foreach (Person currentPerson in Model)
{
    //Wir wollen eine Ausgabe designen
    //M??ssen hier expliziet auch wieder sagen, das die Ausgabe in disem Fall eine Variable ist @


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
Write(currentPerson.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 100 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
Write(currentPerson.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <p>--------------------</p>\r\n");
#nullable restore
#line 103 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 107 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  

    Person[] peoples = Model.ToArray();



    

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
     for (int y = 0; y < Model.Count(); y++)
    {
        Person person1 = peoples[y];

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Name: ");
#nullable restore
#line 116 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
            Write(person1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Name: ");
#nullable restore
#line 117 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
            Write(person1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 118 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 128 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 if (value % 2 == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value was even.</p>\r\n");
#nullable restore
#line 131 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
}



#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 if (value % 2 == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value was even.</p>\r\n");
#nullable restore
#line 138 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
}
else if (value >= 1337)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value is large.</p>\r\n");
#nullable restore
#line 142 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value is odd and small.</p>\r\n");
#nullable restore
#line 146 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 150 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 switch (value)
{
    case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>The value is 1!</p>\r\n");
#nullable restore
#line 154 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
        break;
    case 1337:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Your number is 1337!</p>\r\n");
#nullable restore
#line 157 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
        break;
    default:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Your number wasn\'t 1 or 1337.</p>\r\n");
#nullable restore
#line 160 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
        break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 165 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  var i = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 166 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 while (i < peoples.Length)
{
    var person2 = peoples[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 169 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
        Write(person2.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 170 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
       Write(person2.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 171 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"

    i++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 177 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  i = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 178 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 do
{
    var person3 = peoples[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Name: ");
#nullable restore
#line 181 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
        Write(person3.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 182 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
       Write(person3.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 183 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"

    i++;
} while (i < peoples.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!-- Formular -->\r\n<!-- Formular -->\r\n");
#nullable restore
#line 191 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        Email: <input type=\"email\" id=\"Email\"");
            BeginWriteAttribute("value", " value=\"", 4015, "\"", 4023, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button>Register</button>\r\n    </div>\r\n");
#nullable restore
#line 197 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" //Dispose\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54393c77f6161fbbf3fae037927ef18106e9350118182", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 206 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 try
{
    throw new InvalidOperationException("You did something invalid.");
}
catch (Exception ex)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The exception message: ");
#nullable restore
#line 212 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
                         Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 213 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
}
finally
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The finally statement.</p>\r\n");
#nullable restore
#line 217 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 221 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 lock (obj)
{
    // Do critical section work
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 229 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  
    IEnumerable<WeatherForecast> myWeatherForecasts = service.WeatherForecasts();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 233 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
 foreach (WeatherForecast weatherForecast in myWeatherForecasts)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 235 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  Write(weatherForecast.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 236 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  Write(weatherForecast.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 237 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  Write(weatherForecast.TemperatureC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 238 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
  Write(weatherForecast.TemperatureF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 239 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    \r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            alert(\"Test\");\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
            
    //ERweiterung der Code-Behind Datei
    public string GenericMethod<T>()
    {
        return "a type";
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Aktueller Kurs\ASPNETCORE_MVC_20210928\NET5MVC_20210928\NET5MVC_RazorSamples\Views\RazorSyntaxSamples\Index.cshtml"
            
    private int value = 2;

    private object obj = new object();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWeatherForecastService service { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
