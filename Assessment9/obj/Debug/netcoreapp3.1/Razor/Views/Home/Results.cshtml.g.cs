#pragma checksum "C:\Users\MPatton5\source\repos\Assessment9\Assessment9\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8ca8afba055a9ee4244801f295655864fe22212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 1 "C:\Users\MPatton5\source\repos\Assessment9\Assessment9\Views\_ViewImports.cshtml"
using Assessment9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MPatton5\source\repos\Assessment9\Assessment9\Views\_ViewImports.cshtml"
using Assessment9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8ca8afba055a9ee4244801f295655864fe22212", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26724500ad3260ed592aa0f5bddc165c35b7e229", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Character[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\MPatton5\source\repos\Assessment9\Assessment9\Views\Home\Results.cshtml"
 foreach (Character c in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>------------------</p>\n        <p>Name: ");
#nullable restore
#line 7 "C:\Users\MPatton5\source\repos\Assessment9\Assessment9\Views\Home\Results.cshtml"
            Write(c.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p>Gender: ");
#nullable restore
#line 8 "C:\Users\MPatton5\source\repos\Assessment9\Assessment9\Views\Home\Results.cshtml"
              Write(c.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 9 "C:\Users\MPatton5\source\repos\Assessment9\Assessment9\Views\Home\Results.cshtml"
      

        foreach (string pb in c.playedBy)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <p>Played By: ");
#nullable restore
#line 13 "C:\Users\MPatton5\source\repos\Assessment9\Assessment9\Views\Home\Results.cshtml"
                           Write(pb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\MPatton5\source\repos\Assessment9\Assessment9\Views\Home\Results.cshtml"
                }

     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Character[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
