#pragma checksum "E:\Mrudhula\EmartProject2\EmartProject2\Views\Buyers\CreateDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a03f8670ca81da32123932fb91b737a62d3e46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buyers_CreateDashboard), @"mvc.1.0.view", @"/Views/Buyers/CreateDashboard.cshtml")]
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
#line 1 "E:\Mrudhula\EmartProject2\EmartProject2\Views\_ViewImports.cshtml"
using EmartProject2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mrudhula\EmartProject2\EmartProject2\Views\_ViewImports.cshtml"
using EmartProject2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Mrudhula\EmartProject2\EmartProject2\Views\Buyers\CreateDashboard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a03f8670ca81da32123932fb91b737a62d3e46", @"/Views/Buyers/CreateDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcf6a123ec3033dfd4f29e28531028d1b4a98456", @"/Views/_ViewImports.cshtml")]
    public class Views_Buyers_CreateDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Mrudhula\EmartProject2\EmartProject2\Views\Buyers\CreateDashboard.cshtml"
  
    ViewData["Title"] = "CreateDashboard";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CreateDashboard</h1>\r\n<h4>Welcome ");
#nullable restore
#line 8 "E:\Mrudhula\EmartProject2\EmartProject2\Views\Buyers\CreateDashboard.cshtml"
       Write(Context.Session.GetString("Uname").ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n\r\n");
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
