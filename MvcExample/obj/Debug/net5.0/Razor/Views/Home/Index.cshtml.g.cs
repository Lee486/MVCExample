#pragma checksum "C:\Users\salee\Source\Repos\MVCExample\MvcExample\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddcf5d9f0fa93abc8a8cf3baf4f4cf6070cc2246"
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
#line 1 "C:\Users\salee\Source\Repos\MVCExample\MvcExample\Views\_ViewImports.cshtml"
using MvcExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\salee\Source\Repos\MVCExample\MvcExample\Views\_ViewImports.cshtml"
using MvcExample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddcf5d9f0fa93abc8a8cf3baf4f4cf6070cc2246", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274bdc9c62dad23547f4504147b484c0ea7a325d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\salee\Source\Repos\MVCExample\MvcExample\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!-- Tab links -->
    <div class=""tab"">
        <button class=""tablinks"" data-content=""bar-chart-tabcontent"">Bar Graph</button>
        <button class=""tablinks"" data-content=""line-chart-tabcontent"">Line Graph</button>
        <button class=""tablinks"" data-content=""box-plot-tabcontent"">Box Plot</button>
    </div>

    <!-- Tab content -->
    <div id=""bar-chart-tabcontent"" class=""tabcontent hidden"">
        <h3>Bar Chart</h3>
        <div class=""container-fluid"">
            <div id=""barchart"" class=""chart""></div>
        </div>
    </div>

    <div id=""line-chart-tabcontent"" class=""tabcontent hidden"">
        <h3>Line Chart</h3>
        <div class=""container-fluid"">
            <div id=""linechart"" class=""chart""></div>
        </div>
    </div>

    <div id=""box-plot-tabcontent"" class=""tabcontent hidden"">
        <h3>Box Plot</h3>
        <div class=""container-fluid"">
            <div id=""boxplot"" class=""chart""></div>
        </div>
    </div>
");
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
