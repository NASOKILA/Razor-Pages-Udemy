#pragma checksum "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acb83d6b29c265923a1e2bd60885090c460ba9cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TasteRestaurant.Pages.Order.Pages_Order_OrderPickup), @"mvc.1.0.razor-page", @"/Pages/Order/OrderPickup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Order/OrderPickup.cshtml", typeof(TasteRestaurant.Pages.Order.Pages_Order_OrderPickup), null)]
namespace TasteRestaurant.Pages.Order
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ViewImports.cshtml"
using TasteRestaurant;

#line default
#line hidden
#line 3 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ViewImports.cshtml"
using TasteRestaurant.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb83d6b29c265923a1e2bd60885090c460ba9cc", @"/Pages/Order/OrderPickup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df5ee7320823fe84e039b810beff3a28a9ee02a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Order_OrderPickup : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:65%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-8 form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "OrderPickUpDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
  
    ViewData["Title"] = "OrderPickup";

#line default
#line hidden
            BeginContext(107, 118, true);
            WriteLiteral("\r\n<h2>Order Pickup</h2>\r\n\r\n<br />\r\n\r\n<div class=\"col-sm-12\">\r\n\r\n    <div class=\"col-sm-4 col-sm-offset-8\">\r\n\r\n        ");
            EndContext();
            BeginContext(225, 1393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ffc596de77a4fc0a2f124228449e05f", async() => {
                BeginContext(245, 149, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"pull-right\">\r\n                    <label class=\"radio-inline\">\r\n                        ");
                EndContext();
                BeginContext(395, 70, false);
#line 19 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                   Write(Html.RadioButtonFor(m => m.searchTypeViewModel.SearchCriteria, "Name"));

#line default
#line hidden
                EndContext();
                BeginContext(465, 142, true);
                WriteLiteral("\r\n                        Name&nbsp;\r\n                    </label>\r\n                    <label class=\"radio-inline\">\r\n                        ");
                EndContext();
                BeginContext(608, 71, false);
#line 23 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                   Write(Html.RadioButtonFor(m => m.searchTypeViewModel.SearchCriteria, "Email"));

#line default
#line hidden
                EndContext();
                BeginContext(679, 143, true);
                WriteLiteral("\r\n                        Email&nbsp;\r\n                    </label>\r\n                    <label class=\"radio-inline\">\r\n                        ");
                EndContext();
                BeginContext(823, 71, false);
#line 27 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                   Write(Html.RadioButtonFor(m => m.searchTypeViewModel.SearchCriteria, "Phone"));

#line default
#line hidden
                EndContext();
                BeginContext(894, 143, true);
                WriteLiteral("\r\n                        Phone&nbsp;\r\n                    </label>\r\n                    <label class=\"radio-inline\">\r\n                        ");
                EndContext();
                BeginContext(1038, 77, false);
#line 31 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                   Write(Html.RadioButtonFor(m => m.searchTypeViewModel.SearchCriteria, "OrderNumber"));

#line default
#line hidden
                EndContext();
                BeginContext(1115, 210, true);
                WriteLiteral("\r\n                        Order No.&nbsp;\r\n                    </label>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"pull-right\">\r\n                    ");
                EndContext();
                BeginContext(1325, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "193ae1ed3a994c9da195611ac6fea936", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 38 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.searchTypeViewModel.SearchText);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1442, 169, true);
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary\"><i class=\"fas fa-search\"></i> Search</button>\r\n                </div>\r\n            </div>\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1618, 84, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n\r\n    <br />\r\n    <br />\r\n    <br />\r\n    <hr />\r\n    <br />\r\n\r\n\r\n");
            EndContext();
#line 55 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
     foreach (var item in Model.orderTotalDetails)
    {

#line default
#line hidden
            BeginContext(1761, 106, true);
            WriteLiteral("        <div class=\"row form-border\">\r\n            <div class=\"col-sm-5\">\r\n                Order Number : ");
            EndContext();
            BeginContext(1868, 19, false);
#line 59 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                          Write(item.orderHeader.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1887, 24, true);
            WriteLiteral("\r\n                <ul>\r\n");
            EndContext();
#line 61 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                     foreach (var od in item.orderDetailsList)
                    {

#line default
#line hidden
            BeginContext(1998, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(2028, 7, false);
#line 63 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                        Write(od.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2036, 3, true);
            WriteLiteral(" x ");
            EndContext();
            BeginContext(2041, 8, false);
#line 63 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                                     Write(od.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2050, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 64 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                    }

#line default
#line hidden
            BeginContext(2080, 360, true);
            WriteLiteral(@"                </ul>
            </div>

            <div class=""col-sm-5"">
                <div class=""col-sm-4 col-sm-offset-2"">
                    Order Total:
                    PickUp Time:
                    Order Status:
                    Comments:
                </div>
                <div class=""col-sm-6"">
                    <div>");
            EndContext();
            BeginContext(2441, 27, false);
#line 76 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                    Write(item.orderHeader.OrderTotal);

#line default
#line hidden
            EndContext();
            BeginContext(2468, 33, true);
            WriteLiteral("</div>\r\n                    <div>");
            EndContext();
            BeginContext(2502, 27, false);
#line 77 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                    Write(item.orderHeader.PickUpTime);

#line default
#line hidden
            EndContext();
            BeginContext(2529, 33, true);
            WriteLiteral("</div>\r\n                    <div>");
            EndContext();
            BeginContext(2563, 23, false);
#line 78 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                    Write(item.orderHeader.Status);

#line default
#line hidden
            EndContext();
            BeginContext(2586, 33, true);
            WriteLiteral("</div>\r\n                    <div>");
            EndContext();
            BeginContext(2620, 25, false);
#line 79 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                    Write(item.orderHeader.Comments);

#line default
#line hidden
            EndContext();
            BeginContext(2645, 90, true);
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"col-sm-2\">\r\n");
            EndContext();
#line 84 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                 if (item.orderHeader.Status == "Ready for Pickup")
                {

#line default
#line hidden
            BeginContext(2823, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2843, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17129883f32a4addb21ce9c2dd38e579", async() => {
                BeginContext(2941, 43, true);
                WriteLiteral("<i class=\"fas fa-book\"></i> Pick Up Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                                                            WriteLiteral(item.orderHeader.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2988, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 87 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                }
                else if (item.orderHeader.Status == "Completed")
                {

#line default
#line hidden
            BeginContext(3094, 81, true);
            WriteLiteral("                    <button class=\"btn btn-primary\" disabled>Completed</button>\r\n");
            EndContext();
#line 91 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                }
                else if (item.orderHeader.Status == "Submited")
                {

#line default
#line hidden
            BeginContext(3278, 81, true);
            WriteLiteral("                    <button class=\"btn btn-primary\" disabled>Submitted</button>\r\n");
            EndContext();
#line 95 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                }
                else if (item.orderHeader.Status == "Cancelled")
                {

#line default
#line hidden
            BeginContext(3463, 80, true);
            WriteLiteral("                    <button class=\"btn btn-danger\" disabled>Cancelled</button>\r\n");
            EndContext();
#line 99 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
                }

#line default
#line hidden
            BeginContext(3562, 38, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n");
            EndContext();
            BeginContext(3602, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
#line 105 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
    }

#line default
#line hidden
            BeginContext(3625, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 107 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
     if (Model.orderTotalDetails.Count < 1)
    {

#line default
#line hidden
            BeginContext(3679, 50, true);
            WriteLiteral("        <p>No orders found...</p>\r\n        <br/>\r\n");
            EndContext();
#line 111 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\Order\OrderPickup.cshtml"
    }

#line default
#line hidden
            BeginContext(3736, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TasteRestaurant.Pages.Order.OrderPickupModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TasteRestaurant.Pages.Order.OrderPickupModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TasteRestaurant.Pages.Order.OrderPickupModel>)PageContext?.ViewData;
        public TasteRestaurant.Pages.Order.OrderPickupModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
