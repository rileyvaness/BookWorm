#pragma checksum "C:\Users\riley\source\repos\BookWorm\BookWorm\Views\Home\about.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95fbd97ba8c1a1786511715ad0ea1a232835f1e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_about), @"mvc.1.0.view", @"/Views/Home/about.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/about.cshtml", typeof(AspNetCore.Views_Home_about))]
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
#line 1 "C:\Users\riley\source\repos\BookWorm\BookWorm\Views\_ViewImports.cshtml"
using BookWorm;

#line default
#line hidden
#line 2 "C:\Users\riley\source\repos\BookWorm\BookWorm\Views\_ViewImports.cshtml"
using BookWorm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95fbd97ba8c1a1786511715ad0ea1a232835f1e2", @"/Views/Home/about.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965a3e22dfbcf8f9295cc57377c5cfd9b5c6750c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_about : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\riley\source\repos\BookWorm\BookWorm\Views\Home\about.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\Users\riley\source\repos\BookWorm\BookWorm\Views\Home\about.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 64, true);
            WriteLiteral("</h1>\r\n\r\n<p>This is the page where i will add about page. </p>\r\n");
            EndContext();
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