#pragma checksum "C:\Users\Pc\Northwind\Views\Cms\DisplayTemplates\ImageBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2caba6d2492152bfe7a6fffd71fee9d864bdbea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_ImageBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/ImageBlock.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2caba6d2492152bfe7a6fffd71fee9d864bdbea8", @"/Views/Cms/DisplayTemplates/ImageBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b002a06c34f31d11d1202adb4ca468f7f23e278", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_ImageBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImageBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<img");
            BeginWriteAttribute("src", " src=\"", 23, "\"", 53, 1);
#nullable restore
#line 3 "C:\Users\Pc\Northwind\Views\Cms\DisplayTemplates\ImageBlock.cshtml"
WriteAttributeValue("", 29, Url.Content(Model.Body), 29, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
