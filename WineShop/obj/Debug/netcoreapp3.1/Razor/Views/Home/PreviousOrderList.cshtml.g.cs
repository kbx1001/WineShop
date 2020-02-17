#pragma checksum "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2f9b82f6d3d7b14f172c1af6baabbe3cb82dbb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PreviousOrderList), @"mvc.1.0.view", @"/Views/Home/PreviousOrderList.cshtml")]
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
#line 1 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\_ViewImports.cshtml"
using WineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\_ViewImports.cshtml"
using WineShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2f9b82f6d3d7b14f172c1af6baabbe3cb82dbb6", @"/Views/Home/PreviousOrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff04dee3b6abe594e2f0c865c57c75d1e805ab06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PreviousOrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Orders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shopping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerifyRefund", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
  
    ViewData["Title"] = "Previous Orders";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Previous Order List</h1>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>Order Number</th>
                <th>OrderDate</th>
                <th>OrderStatus</th>
                <th>Item</th>
                <th>Quantity</th>
                <th>Price</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
             foreach (var order in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                 if (order.OrderStatusId == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                       Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                       Write(order.OrderDate.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 40 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                                              Write(order.OrderDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 40 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                                                                   Write(order.OrderDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                       Write(order.OrderStatus.OrderStatusDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                       Write(order.Item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                       Write(order.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                       Write(order.OrderTotal.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f9b82f6d3d7b14f172c1af6baabbe3cb82dbb67703", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-dark\" name=\"order\"");
                BeginWriteAttribute("value", " value=\"", 1553, "\"", 1575, 1);
#nullable restore
#line 47 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
WriteAttributeValue("", 1561, order.OrderId, 1561, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Return Item</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 55 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>You currently do not have any orders placed!</p>\r\n");
#nullable restore
#line 59 "C:\Users\Christian\source\repos\WineShop\WineShop\Views\Home\PreviousOrderList.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
