#pragma checksum "C:\Users\96658\source\repos\EFMVCPoject\Views\OrderLines\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537566531024d0a5fd1916de18621b81d4440c0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderLines_Index), @"mvc.1.0.view", @"/Views/OrderLines/Index.cshtml")]
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
#line 1 "C:\Users\96658\source\repos\EFMVCPoject\Views\_ViewImports.cshtml"
using EFMVCPoject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\96658\source\repos\EFMVCPoject\Views\_ViewImports.cshtml"
using EFMVCPoject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"537566531024d0a5fd1916de18621b81d4440c0e", @"/Views/OrderLines/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9cb3b85ec8f52e0db7e610a579ea572f86b1a1", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderLines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\96658\source\repos\EFMVCPoject\Views\OrderLines\Index.cshtml"
  
    List<OrderLineModel> orderLines = (List<OrderLineModel>)ViewData["OrderLines"];


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>This is a Order Line Index</h1>\r\n\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <td>ID</td>\r\n            <td>Quantity</td>\r\n            <td>Subtotal</td>\r\n            <td>OrderID</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\96658\source\repos\EFMVCPoject\Views\OrderLines\Index.cshtml"
          
            foreach (var item in orderLines)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\96658\source\repos\EFMVCPoject\Views\OrderLines\Index.cshtml"
                   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\96658\source\repos\EFMVCPoject\Views\OrderLines\Index.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\96658\source\repos\EFMVCPoject\Views\OrderLines\Index.cshtml"
                   Write(item.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\96658\source\repos\EFMVCPoject\Views\OrderLines\Index.cshtml"
                   Write(item.OrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\96658\source\repos\EFMVCPoject\Views\OrderLines\Index.cshtml"

            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
