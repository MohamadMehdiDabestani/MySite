#pragma checksum "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f419cd18e69190f3c65594f27accbc7703fadbb"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f419cd18e69190f3c65594f27accbc7703fadbb", @"/Views/Home/GetPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fdd28988c7da921b39265aab475d129aee1938c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetPostViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("header", async() => {
                WriteLiteral("\n    <title>محمد مهدی - ");
#nullable restore
#line 3 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                  Write(Model.TitleOfBrowser);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n    <meta name=\"Description\"");
                BeginWriteAttribute("content", " content=\"", 123, "\"", 151, 1);
#nullable restore
#line 4 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
WriteAttributeValue("", 133, Model.Description, 133, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n");
            }
            );
            WriteLiteral("<div class=\"uk-container container-post\">\n    <div uk-grid>\n        <div class=\"uk-width-expand\">\n            <div class=\"text-post\">\n                <h1>");
#nullable restore
#line 10 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                <img");
            BeginWriteAttribute("src", " src=\"", 350, "\"", 384, 2);
            WriteAttributeValue("", 356, "/PostImages/", 356, 12, true);
#nullable restore
#line 11 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
WriteAttributeValue("", 368, Model.ImageName, 368, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 385, "\"", 406, 1);
#nullable restore
#line 11 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
WriteAttributeValue("", 391, Model.AltImage, 391, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                <p>\n                    ");
#nullable restore
#line 13 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
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
            BeginWriteAttribute("alt", " alt=\"", 806, "\"", 812, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                        <p>تاریخ ثبت : ");
#nullable restore
#line 23 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                                  Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                    <div class=\"category\">\n                        <img src=\"/images/category.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1003, "\"", 1009, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                        <p>دسته بندی : ");
#nullable restore
#line 27 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                                  Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                    \n                    <div class=\"tags\">\n                        <img src=\"/images/tags.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1211, "\"", 1217, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                        <p>کلمات کلیدی :</p>\n                        <ul>\n");
#nullable restore
#line 34 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                             foreach (var item in Model.Tags)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 36 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 37 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n                    </div>\n                    <p>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1572, "\"", 1605, 2);
            WriteAttributeValue("", 1579, "/admin/editepost/", 1579, 17, true);
#nullable restore
#line 41 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
WriteAttributeValue("", 1596, Model.id, 1596, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uk-button uk-button-primary uk-button-small\">Edite</a>\n                    </p>\n                    <p>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1744, "\"", 1778, 2);
            WriteAttributeValue("", 1751, "/admin/deletepost/", 1751, 18, true);
#nullable restore
#line 44 "/media/mmd/inestall/My Site/Backend/Views/Home/GetPost.cshtml"
WriteAttributeValue("", 1769, Model.id, 1769, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uk-button uk-button-danger uk-button-small\">Delete</a>\n                    </p>\n                </div>\n            </aside>\n        </div>\n    </div>\n</div>");
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
