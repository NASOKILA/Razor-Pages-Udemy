#pragma checksum "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_UnderscoreTableButtonsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ed3e518f61ff8fd65ddd4a48688e8295b52313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TasteRestaurant.Pages.Pages__UnderscoreTableButtonsPartial), @"mvc.1.0.view", @"/Pages/_UnderscoreTableButtonsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/_UnderscoreTableButtonsPartial.cshtml", typeof(TasteRestaurant.Pages.Pages__UnderscoreTableButtonsPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ed3e518f61ff8fd65ddd4a48688e8295b52313", @"/Pages/_UnderscoreTableButtonsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5df5ee7320823fe84e039b810beff3a28a9ee02a", @"/Pages/_ViewImports.cshtml")]
    public class Pages__UnderscoreTableButtonsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.IndivdualButtonPartial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(156, 54, true);
            WriteLiteral("\r\n\r\n    <div class=\"btn-group\" role=\"group\">\r\n        ");
            EndContext();
            BeginContext(211, 210, false);
#line 7 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_UnderscoreTableButtonsPartial.cshtml"
   Write(Html.Partial("_IndividualButtonPartial",
     new IndivdualButtonPartial()
     {
         Page = "Details",
         ButtonType = "btn-primary",
         Glyph = "pencil",
         Id = Model.Id
     }));

#line default
#line hidden
            EndContext();
            BeginContext(421, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(434, 205, false);
#line 16 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_UnderscoreTableButtonsPartial.cshtml"
   Write(Html.Partial("_IndividualButtonPartial",
     new IndivdualButtonPartial()
     {
         Page = "Edit",
         ButtonType = "btn-warning",
         Glyph = "book",
         Id = Model.Id
     }));

#line default
#line hidden
            EndContext();
            BeginContext(639, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(652, 207, false);
#line 25 "C:\Users\Asus\Desktop\Courses\Razor-Pages-Udemy\03.Taste Restaurant\TasteRestaurant\TasteRestaurant\Pages\_UnderscoreTableButtonsPartial.cshtml"
   Write(Html.Partial("_IndividualButtonPartial",
     new IndivdualButtonPartial()
     {
         Page = "Delete",
         ButtonType = "btn-danger",
         Glyph = "trash",
         Id = Model.Id
     }));

#line default
#line hidden
            EndContext();
            BeginContext(859, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.IndivdualButtonPartial> Html { get; private set; }
    }
}
#pragma warning restore 1591
