#pragma checksum "C:\Dev\TestProjects\HotelsViewer\HotelsViewer\Views\Shared\Components\SideMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7277b25c198e6a33010b645100c3c78473eb5a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SideMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_SideMenu_Default))]
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
#line 3 "C:\Dev\TestProjects\HotelsViewer\HotelsViewer\Views\Shared\_ViewImports.cshtml"
using HotelsViewer.Controllers;

#line default
#line hidden
#line 5 "C:\Dev\TestProjects\HotelsViewer\HotelsViewer\Views\Shared\_ViewImports.cshtml"
using HotelsViewer.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7277b25c198e6a33010b645100c3c78473eb5a0", @"/Views/Shared/Components/SideMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6cdc10a482295da05781e13c175ba56a1be432a", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 185, true);
            WriteLiteral("<div class=\"col-md-3\">\r\n  <aside class=\"sidebar-left\">\r\n\r\n    <div class=\"sidebar-widget\">\r\n      <h4>Menu</h4>\r\n      <ul class=\"icon-list list-category\">\r\n\r\n        <li>\r\n          <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 185, "\"", 246, 1);
#line 9 "C:\Dev\TestProjects\HotelsViewer\HotelsViewer\Views\Shared\Components\SideMenu\Default.cshtml"
WriteAttributeValue("", 192, Url.RouteUrl("HotelsByCity", new { city = "batumi" }), 192, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(247, 131, true);
            WriteLiteral(">\r\n            <i class=\"fa fa-angle-right\"></i>\r\n            All Hotels\r\n          </a>\r\n        </li>\r\n        <li>\r\n          <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 378, "\"", 439, 1);
#line 15 "C:\Dev\TestProjects\HotelsViewer\HotelsViewer\Views\Shared\Components\SideMenu\Default.cshtml"
WriteAttributeValue("", 385, Url.RouteUrl("HotelsByCity", new { city = "batumi" }), 385, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(440, 157, true);
            WriteLiteral(">\r\n            <i class=\"fa fa-angle-right\"></i>\r\n            Add New Hotel\r\n          </a>\r\n        </li>\r\n\r\n      </ul>\r\n    </div>\r\n\r\n  </aside>\r\n</div>\r\n");
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
