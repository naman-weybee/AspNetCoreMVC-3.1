#pragma checksum "D:\.NET\ASP.NET Core MVC\WebGentle App\WebGentle.BookStore\WebGentle.BookStore\Views\Shared\_footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3cadf6af71b7291444f9078bda106c6d62fb177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__footer), @"mvc.1.0.view", @"/Views/Shared/_footer.cshtml")]
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
#line 1 "D:\.NET\ASP.NET Core MVC\WebGentle App\WebGentle.BookStore\WebGentle.BookStore\Views\_ViewImports.cshtml"
using WebGentle.BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3cadf6af71b7291444f9078bda106c6d62fb177", @"/Views/Shared/_footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d95dddaec7323b61ab90913e8b164d080a470b74", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer class=\"border-top footer text-muted text-center\">\r\n    <div class=\"container\">\r\n        Copyright &copy; Book Store ");
#nullable restore
#line 3 "D:\.NET\ASP.NET Core MVC\WebGentle App\WebGentle.BookStore\WebGentle.BookStore\Views\Shared\_footer.cshtml"
                               Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</footer>");
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
