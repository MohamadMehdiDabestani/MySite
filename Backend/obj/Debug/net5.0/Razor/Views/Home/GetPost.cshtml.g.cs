#pragma checksum "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5742b49f1865aa9389f00410671f6294dda985e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetPost), @"mvc.1.0.view", @"/Views/Home/GetPost.cshtml")]
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
#line 2 "/media/mmd/inestall/My Site/Backend/Views/_ViewImports.cshtml"
using Backend.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/mmd/inestall/My Site/Backend/Views/_ViewImports.cshtml"
using Backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5742b49f1865aa9389f00410671f6294dda985e2", @"/Views/Home/GetPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fdd28988c7da921b39265aab475d129aee1938c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetPostViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"uk-container container-post\">\n    <div uk-grid>\n        <div class=\"uk-width-expand\">\n            <div class=\"text-post\">\n                <h1>");
#nullable restore
#line 6 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                <img");
            BeginWriteAttribute("src", " src=\"", 216, "\"", 250, 2);
            WriteAttributeValue("", 222, "/PostImages/", 222, 12, true);
#nullable restore
#line 7 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
WriteAttributeValue("", 234, Model.ImageName, 234, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 251, "\"", 272, 1);
#nullable restore
#line 7 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
WriteAttributeValue("", 257, Model.AltImage, 257, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                <p>\n                    ");
#nullable restore
#line 9 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
               Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>
        <div class=""uk-width-1-3@m"">
            <aside>
                <div class=""info-post"" uk-sticky=""offset: 10;animation: uk-animation-fade"">
                    <p>اطلاعات پست</p>
                    <div class=""create-date"">
                        <img src=""/images/booking.svg""");
            BeginWriteAttribute("alt", " alt=\"", 672, "\"", 678, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                        <p>تاریخ ثبت : ");
#nullable restore
#line 19 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                                  Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                    <div class=\"category\">\n                        <img src=\"/images/category.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 869, "\"", 875, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                        <p>دسته بندی : ");
#nullable restore
#line 23 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                                  Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                    \n                    <div class=\"tags\">\n                        <img src=\"/images/tags.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1077, "\"", 1083, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                        <p>کلمات کلیدی :</p>\n                        <ul>\n");
#nullable restore
#line 30 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                             foreach (var item in Model.Tags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 32 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 33 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n                    </div>\n                </div>\n            </aside>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetPostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
