#pragma checksum "D:\工作\C#\netCore.Mvc\MyMvc\Views\HelloWorld\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7981782f0c30546b6cc2171390804109ba47c8f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Welcome), @"mvc.1.0.view", @"/Views/HelloWorld/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Welcome.cshtml", typeof(AspNetCore.Views_HelloWorld_Welcome))]
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
#line 1 "D:\工作\C#\netCore.Mvc\MyMvc\Views\_ViewImports.cshtml"
using MyMvc;

#line default
#line hidden
#line 2 "D:\工作\C#\netCore.Mvc\MyMvc\Views\_ViewImports.cshtml"
using MyMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7981782f0c30546b6cc2171390804109ba47c8f3", @"/Views/HelloWorld/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd5bfbc8c0afc8486ea0c737c387ff84e704d3b5", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\工作\C#\netCore.Mvc\MyMvc\Views\HelloWorld\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(45, 62, true);
            WriteLiteral("\r\n<p>Welcome?name=\'\'&age=..</p>\r\n<ul style=\"font-size:20px\">\r\n");
            EndContext();
#line 8 "D:\工作\C#\netCore.Mvc\MyMvc\Views\HelloWorld\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["age"]; i++)
    {

#line default
#line hidden
            BeginContext(167, 9, true);
            WriteLiteral("    <li> ");
            EndContext();
            BeginContext(177, 11, false);
#line 10 "D:\工作\C#\netCore.Mvc\MyMvc\Views\HelloWorld\Welcome.cshtml"
    Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(188, 15, true);
            WriteLiteral(" + &nbsp;   Im ");
            EndContext();
#line 10 "D:\工作\C#\netCore.Mvc\MyMvc\Views\HelloWorld\Welcome.cshtml"
                                       i.ToString(); 

#line default
#line hidden
            BeginContext(221, 29, true);
            WriteLiteral(" years old!\r\n        </li> \r\n");
            EndContext();
#line 12 "D:\工作\C#\netCore.Mvc\MyMvc\Views\HelloWorld\Welcome.cshtml"
        }

#line default
#line hidden
            BeginContext(261, 12, true);
            WriteLiteral("\r\n</ul>\r\n \r\n");
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