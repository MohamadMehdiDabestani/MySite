#pragma checksum "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ae9cc212e49eca535dc3c7225283afcad776c3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16ae9cc212e49eca535dc3c7225283afcad776c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fdd28988c7da921b39265aab475d129aee1938c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AddProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AddXp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteXp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("header", async() => {
                WriteLiteral("\n    <meta name=\"description\" content=\"من محمد مهدی هستم طراح و توسعه ی دهنده ی وب که از سال 1397 ...\" />\n    <title>محمد مهدی</title>\n");
            }
            );
#nullable restore
#line 5 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
  
    var listXp = ViewBag.ListXp as List<MyXp>;
    var listUrl = ViewBag.ProjectSuccesUrl;
    var listPost = ViewBag.ListPost as List<GetAllPostViewModel>;
    var ListComment = ViewBag.Comments as List<Comments>;
    var CheckComment = ListComment.Count == 0 ? true : false; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16ae9cc212e49eca535dc3c7225283afcad776c34480", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16ae9cc212e49eca535dc3c7225283afcad776c35579", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16ae9cc212e49eca535dc3c7225283afcad776c36678", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            DefineSection("headerContianer", async() => {
                WriteLiteral(@"
    <div class=""header-container"">
        <div>
            <h4>درباره ی من</h4>
            <p>
                من محمد مهدی دبستانی هستم . طراح و توسعه دهنده ی وب از سال 1397 شروع
                کرده ام . در شاخه ی وب با تکنولوژی هایی کار کرده ام که قسمت پایین میتونید ببینید . همچنین شما
                میتوانید که رزومه ی من رو از طریق <a href=""/CV.pdf"" download>لینک</a> دریافت کنید
            </p>
            <li>
                <a uk-toggle=""target: #add_project_modal"">
                    ثبت پروژه
                </a>
                
            </li>
            <li>
                <a uk-toggle=""target: #AddXpModal"">
                    ثبت تکنولوژی
                </a>
            </li>
            <li>
                <a uk-toggle=""target: #DeleteXpModal"">
                    حذف تکنولوژی
                </a>
            </li>
        </div>
        <div>
            <img src=""/images/logo.png"" alt=""Logo Mohamadmehdi"" />
        </div>
    </div>
");
            }
            );
            WriteLiteral("<div class=\"uk-container my-xp\">\n    <div class=\"uk-grid-column-small uk-grid-row-small uk-child-width-1-3@s uk-grid-match\" uk-grid>\n");
#nullable restore
#line 48 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
         foreach (var xp in listXp)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                <div class=\"card-xp\">\n                    <p class=\"uk-align-left\">");
#nullable restore
#line 52 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                                        Write(xp.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 52 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                                                    Write(xp.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <progress class=\"uk-progress\"");
            BeginWriteAttribute("value", " value=\"", 1884, "\"", 1901, 1);
#nullable restore
#line 53 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
WriteAttributeValue("", 1892, xp.value, 1892, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" max=\"100\"></progress>\n                </div>\n            </div>\n");
#nullable restore
#line 56 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<div id=""modal"" class=""uk-flex-top"" uk-modal>
        <div class=""uk-modal-dialog"" uk-overflow-auto>
            <div class=""uk-modal-header"">
                <h2 class=""uk-modal-title"">آدرس سایت ها :</h2>
            </div>

            <div class=""uk-modal-body"">

                <button class=""uk-modal-close-default"" type=""button"" uk-close></button>
                <ul>
");
#nullable restore
#line 69 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                     foreach (var url in listUrl)
                    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2476, "\"", 2487, 1);
#nullable restore
#line 71 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
WriteAttributeValue("", 2483, url, 2483, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                                      Write(url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 72 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
           
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
            <div class=""uk-modal-footer uk-text-right"">
                <button class=""uk-button uk-button-default uk-modal-close"" type=""button"">بستن</button>
            </div>
        </div>
</div>
<!-- certificates -->
<div class=""list-certificate"">
    <div class=""uk-container"">
        <h3>پروژ ها :</h3>
        <div class=""uk-grid-column-small uk-grid-row-small uk-child-width-1-3@s uk-grid-match"" uk-grid>
            <div>
                <div class=""project"">
                    <img src=""/images/icons8-mission-100.png""");
            BeginWriteAttribute("alt", " alt=\"", 3110, "\"", 3116, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                    <p uk-toggle=\"target: #modal\"  class=\"cursor\" >پروژه ی موفق : ");
#nullable restore
#line 89 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                                                                             Write(ViewBag.ProjectSucces);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                </div>\n            </div>\n            <div>\n                <div class=\"project\">\n                    <img src=\"/images/working.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3379, "\"", 3385, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                    <p>پروژه درحال انجام : ");
#nullable restore
#line 95 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                                      Write(ViewBag.ProjectWorking);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n            <div>\n                <div class=\"project\">\n                    <img src=\"/images/error.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3607, "\"", 3613, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n                    <p>پروژه ی شکست خورده : ");
#nullable restore
#line 101 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                                       Write(ViewBag.ProjectFaild);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""uk-container uk-margin-medium-top"">
    <h3>آخرین پست ها :</h3>
    <div class=""uk-grid-column-small uk-grid-row-small uk-child-width-1-3@s uk-grid-match"" uk-grid>
");
#nullable restore
#line 110 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
         foreach (var post in listPost)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\n            <div class=\"uk-text-center example-work\">\n                <div class=\"image-example\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4136, "\"", 4157, 2);
            WriteAttributeValue("", 4143, "/post/", 4143, 6, true);
#nullable restore
#line 116 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
WriteAttributeValue("", 4149, post.id, 4149, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 4188, "\"", 4221, 2);
            WriteAttributeValue("", 4194, "/PostImages/", 4194, 12, true);
#nullable restore
#line 117 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
WriteAttributeValue("", 4206, post.ImageName, 4206, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4222, "\"", 4242, 1);
#nullable restore
#line 117 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
WriteAttributeValue("", 4228, post.AltImage, 4228, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                    </a>\n                </div>\n                <div class=\"example-work-text uk-padding-small\">\n                    <h4 class=\"uk-text-right uk-margin-small\">");
#nullable restore
#line 121 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                                                         Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    <p class=\"uk-margin-remove\">\n                        ");
#nullable restore
#line 123 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                   Write(post.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <div class=""svg-wrapper"">
                        <svg height=""40"" width=""150"" xmlns=""http://www.w3.org/2000/svg"">
                            <rect id=""shape"" height=""40"" width=""150"" />
                            <div id=""text"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 4840, "\"", 4861, 2);
            WriteAttributeValue("", 4847, "/post/", 4847, 6, true);
#nullable restore
#line 129 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
WriteAttributeValue("", 4853, post.id, 4853, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <span class=""spot""></span>
                                    ادامه ی مطلب
                                </a>
                            </div>
                        </svg>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 139 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n    <div class=\"uk-flex uk-flex-center uk-margin-medium-top\">\n        <ul class=\"uk-pagination\" uk-margin>\n");
#nullable restore
#line 143 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
             for(int i =1; i<=ViewBag.pageCount+1;i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 5379, "\"", 5426, 1);
#nullable restore
#line 145 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
WriteAttributeValue("", 5387, (ViewBag.PageId == i)?"uk-active":"", 5387, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 5430, "\"", 5458, 2);
            WriteAttributeValue("", 5437, "/Home/Index?pageid=", 5437, 19, true);
#nullable restore
#line 145 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
WriteAttributeValue("", 5456, i, 5456, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 145 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 146 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>
</div>
<hr class=""uk-divider-icon uk-margin-medium-top"" />
<div class=""jupiter-comment uk-container uk-margin-small-top"">
    <h3>نظرات مشتری :</h3>
    <div class=""uk-position-relative uk-visible-toggle uk-light carousel"" tabindex=""-1""
        uk-slideshow=""animation: push;autoplay:true;autoplay-interval:4000"">
");
#nullable restore
#line 155 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
         if(!CheckComment){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"uk-slideshow-items\">\n");
#nullable restore
#line 157 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                 foreach (var item in ListComment)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\n                                <a class=\"uk-button uk-button-danger\" style=\"max-height: 20px !important;\n    min-height: 35px !important;\"");
            BeginWriteAttribute("href", " href=\"", 6130, "\"", 6173, 2);
            WriteAttributeValue("", 6137, "/Admin/DeleteComment/", 6137, 21, true);
#nullable restore
#line 161 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
WriteAttributeValue("", 6158, item.CommentId, 6158, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n                        <div class=\"uk-position-center uk-position-small uk-text-center\">\n                            <h2 uk-slideshow-parallax=\"x: 100,-100;y:300,150;opacity: 1,1,0\">\n                                ");
#nullable restore
#line 164 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                           Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </h2>\n                            <p uk-slideshow-parallax=\"x: 200,-200;y:75,-50;opacity: 1,1,0\">\n                                ");
#nullable restore
#line 167 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                           Write(item.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </p>\n                        </div>\n                    </li>\n");
#nullable restore
#line 171 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n");
#nullable restore
#line 173 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            
        <a class=""uk-position-center-right uk-position-small uk-hidden-hover"" href=""#"" uk-slidenav-previous
            uk-slideshow-item=""next""></a>
        <a class=""uk-position-center-left uk-position-small uk-hidden-hover"" href=""#"" uk-slidenav-next
            uk-slideshow-item=""previous""></a>

    </div>
");
#nullable restore
#line 181 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
     if(CheckComment) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert-comment\"><p>نظری وجود ندارد</p></div>\n");
#nullable restore
#line 183 "/media/mmd/inestall/My Site/Backend/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
