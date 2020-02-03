#pragma checksum "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bcc162cfc6ed708678ab7a8897a9e7ba72b56e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Archive), @"mvc.1.0.view", @"/Views/Cms/Archive.cshtml")]
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
#line 3 "C:\Users\Pc\Northwind\Views\_ViewImports.cshtml"
using Piranha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pc\Northwind\Views\_ViewImports.cshtml"
using Piranha.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pc\Northwind\Views\_ViewImports.cshtml"
using Piranha.Extend.Blocks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pc\Northwind\Views\_ViewImports.cshtml"
using Northwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bcc162cfc6ed708678ab7a8897a9e7ba72b56e1", @"/Views/Cms/Archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b002a06c34f31d11d1202adb4ca468f7f23e278", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogArchive>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
  
    ViewBag.Title = Model.Title;
    ViewBag.HasImage = Model.Hero.PrimaryImage.HasValue;

    string PrimaryImage() {
        if (Model.Hero.PrimaryImage.HasValue) {
            return $"style=background-image:url({Url.Content(Model.Hero.PrimaryImage)})";
        } 
        return "";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header class=\"page-header\" ");
#nullable restore
#line 15 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                       Write(PrimaryImage());

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-sm-9\">\n");
#nullable restore
#line 19 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                 if (Model.Archive.Category == null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1>");
#nullable restore
#line 20 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 21 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h1>");
#nullable restore
#line 22 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                   Write(Model.Archive.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 23 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"lead\">\n                    ");
#nullable restore
#line 25 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
               Write(Html.Raw(Model.Hero.Ingress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </div>\n        </div>\n    </div>\n</header>\n\n<div class=\"main\">\n    <div class=\"container\">\n");
#nullable restore
#line 34 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
         foreach (var post in Model.Archive.Posts) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row archive-item\">\n                <div class=\"col-sm-12\">\n                    <h2><a");
            BeginWriteAttribute("href", " href=\"", 1021, "\"", 1043, 1);
#nullable restore
#line 37 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1028, post.Permalink, 1028, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                                             Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n                    <p>\n                        <strong>");
#nullable restore
#line 39 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                           Write(post.Published.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> in \n                        <a");
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1258, 3);
#nullable restore
#line 40 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1213, Model.Permalink, 1213, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1229, "/category/", 1229, 10, true);
#nullable restore
#line 40 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1239, post.Category.Slug, 1239, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                                                                           Write(post.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                    </p>\n                </div>\n                <div class=\"col-sm-9\">\n                    <p>\n                        ");
#nullable restore
#line 45 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                   Write(post.Regions.Hero.Ingress.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n                    </p>\n                    <p><a");
            BeginWriteAttribute("href", " href=\"", 1504, "\"", 1526, 1);
#nullable restore
#line 47 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
WriteAttributeValue("", 1511, post.Permalink, 1511, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read more...</a></p>\n                </div>\n                <div class=\"col-sm-3 d-xs-none d-md-block\">\n");
#nullable restore
#line 50 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                     foreach (var tag in post.Tags) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"tag\"># ");
#nullable restore
#line 51 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                                       Write(tag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 52 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n");
#nullable restore
#line 55 "C:\Users\Pc\Northwind\Views\Cms\Archive.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogArchive> Html { get; private set; }
    }
}
#pragma warning restore 1591
