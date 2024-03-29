#pragma checksum "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af1763bbbcbd0fa56dc687270b4855517db032de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Custom), @"mvc.1.0.view", @"/Views/Cms/Custom.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af1763bbbcbd0fa56dc687270b4855517db032de", @"/Views/Cms/Custom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b002a06c34f31d11d1202adb4ca468f7f23e278", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Custom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomPage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
  
    ViewBag.Title = Model.Title;
    ViewBag.HasImage = Model.Hero.PrimaryImage.HasValue;

    string PrimaryImage()
    {
        if (Model.Hero.PrimaryImage.HasValue)
        {
            return $"style=background-image:url({Url.Content(Model.Hero.PrimaryImage)})";
        }
        return "";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"page-header\" ");
#nullable restore
#line 20 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                       Write(PrimaryImage());

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-9\">\r\n                <h1>");
#nullable restore
#line 24 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <p class=\"lead\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
               Write(Html.Raw(Model.Hero.Ingress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</header>\r\n\r\n<div class=\"main\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 35 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
         if (Model.Teasers.Count > 0)
        {
            var pos = 0;
            var size = 4;

            while (pos < Model.Teasers.Count)
            {
                var rest = Model.Teasers.Count - pos;
                var cols = 0;

                if (rest == 1)
                {
                    size = 8;
                    cols = 1;
                }
                else if (rest <= 4 && rest % 3 != 0 && rest % 2 == 0)
                {
                    size = 6;
                    cols = 2;
                }
                else
                {
                    size = 4;
                    cols = 3;
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row justify-content-center teasers\">\r\n");
#nullable restore
#line 62 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                     for (var n = 0; n < cols; n++)
                    {
                        var teaser = Model.Teasers[pos + n];


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1677, "\"", 1713, 4);
            WriteAttributeValue("", 1685, "col-sm-6", 1685, 8, true);
            WriteAttributeValue(" ", 1693, "col-md-", 1694, 8, true);
#nullable restore
#line 66 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
WriteAttributeValue("", 1701, size, 1701, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1706, "teaser", 1707, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"teaser-body\">\r\n                                <span class=\"teaser-subtitle\">");
#nullable restore
#line 68 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                                                         Write(teaser.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h3>");
#nullable restore
#line 69 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                               Write(teaser.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                ");
#nullable restore
#line 70 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                           Write(Html.Raw(teaser.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                                 if (teaser.PageLink.HasValue)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p><a");
            BeginWriteAttribute("href", " href=\"", 2111, "\"", 2149, 1);
#nullable restore
#line 73 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
WriteAttributeValue("", 2118, teaser.PageLink.Page.Permalink, 2118, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read more..</a></p>\r\n");
#nullable restore
#line 74 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                                }
                                else if (teaser.PostLink.HasValue)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p><a");
            BeginWriteAttribute("href", " href=\"", 2351, "\"", 2389, 1);
#nullable restore
#line 77 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
WriteAttributeValue("", 2358, teaser.PostLink.Post.Permalink, 2358, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read more..</a></p>\r\n");
#nullable restore
#line 78 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 81 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 83 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
                pos += cols;
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"row justify-content-center\">\r\n            <div class=\"col-sm-10 page-body\">\r\n                ");
#nullable restore
#line 89 "C:\Users\Pc\Northwind\Views\Cms\Custom.cshtml"
           Write(Html.DisplayFor(m => m.Blocks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IApi Api { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomPage> Html { get; private set; }
    }
}
#pragma warning restore 1591
