#pragma checksum "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6994b57b8d863fa9a00117fdf7815833494f78b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TasteRestaurant.Pages.Pages__ThumbnailAreaPartial), @"mvc.1.0.view", @"/Pages/_ThumbnailAreaPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/_ThumbnailAreaPartial.cshtml", typeof(TasteRestaurant.Pages.Pages__ThumbnailAreaPartial))]
namespace TasteRestaurant.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ViewImports.cshtml"
using TasteRestaurant;

#line default
#line hidden
#line 3 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ViewImports.cshtml"
using TasteRestaurant.Data;

#line default
#line hidden
#line 5 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
using TasteRestaurant.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6994b57b8d863fa9a00117fdf7815833494f78b", @"/Pages/_ThumbnailAreaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df5ee7320823fe84e039b810beff3a28a9ee02a", @"/Pages/_ViewImports.cshtml")]
    public class Pages__ThumbnailAreaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(150, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
 if (Model != null)
{
    
    foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(257, 203, true);
            WriteLiteral("        <div class=\"thumbnail col-sm-10 col-sm-offset-1\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-10\">\r\n                    <label class=\"text-primary\" style=\"font-size:17px;\">");
            EndContext();
            BeginContext(461, 9, false);
#line 15 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(470, 38, true);
            WriteLiteral("</label>\r\n                    <br />\r\n");
            EndContext();
#line 17 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                     if (item.Spicyness == SD.Zero)
                    {

#line default
#line hidden
            BeginContext(584, 93, true);
            WriteLiteral("                        <label class=\"label label-success\" style=\"width:100px; height:25px;\">");
            EndContext();
            BeginContext(678, 20, false);
#line 19 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                                                                                        Write(MenuItem.ESpicy.Mild);

#line default
#line hidden
            EndContext();
            BeginContext(698, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 20 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                    }
                    else if (item.Spicyness == SD.One)
                    {

#line default
#line hidden
            BeginContext(810, 93, true);
            WriteLiteral("                        <label class=\"label label-warning\" style=\"width:100px; height:25px;\">");
            EndContext();
            BeginContext(904, 24, false);
#line 23 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                                                                                        Write(MenuItem.ESpicy.Moderate);

#line default
#line hidden
            EndContext();
            BeginContext(928, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 24 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                    }
                    else if (item.Spicyness == SD.Two)
                    {

#line default
#line hidden
            BeginContext(1040, 92, true);
            WriteLiteral("                        <label class=\"label label-danger\" style=\"width:100px; height:25px;\">");
            EndContext();
            BeginContext(1133, 20, false);
#line 27 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                                                                                       Write(MenuItem.ESpicy.High);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 28 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                    }

#line default
#line hidden
            BeginContext(1186, 89, true);
            WriteLiteral("                    <label class=\"label label-default\" style=\"width:100px; height:25px;\">");
            EndContext();
            BeginContext(1276, 18, false);
#line 29 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                                                                                    Write(item.FoodType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 110, true);
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"col-sm-2 text-right\">\r\n                    <h4>$");
            EndContext();
            BeginContext(1405, 10, false);
#line 32 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                    Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 146, true);
            WriteLiteral("</h4>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-10\">\r\n                    <p>");
            EndContext();
            BeginContext(1562, 69, false);
#line 37 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                  Write(item.Description.Substring(0, Math.Min(100, item.Description.Length)));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 107, true);
            WriteLiteral(" . . .</p>\r\n                </div>\r\n                <div class=\"col-sm-2 text-right\">\r\n                    ");
            EndContext();
            BeginContext(1738, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb597256898b449e95dae559e68e1bec", async() => {
                BeginContext(1808, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
                                            WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1819, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 44 "C:\Users\Asus\Desktop\.NET Rzor Pages Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_ThumbnailAreaPartial.cshtml"
    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
